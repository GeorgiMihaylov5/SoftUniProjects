using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
       [Test]
       public void Test_Ctor_Throw_Exeption_With_Negative_Capacity()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Shop shop = new Shop(-1);
            });

        }
        [Test]
        public void Test_Ctor_With_Positive_Capacity()
        {
            Shop shop = new Shop(100);

            Assert.AreEqual(100, shop.Capacity);
        }
        [Test]
        public void Test_Add_Phone_Throw_Exeption_If_Exist()
        {
            Shop shop = new Shop(10);
            shop.Add(new Smartphone("Samsung", 100));

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(new Smartphone("Samsung", 100));
            });
        }
        [Test]
        public void Test_Add_Phone_Throw_Exeption_If_Dont_Have_Capacity()
        {
            Shop shop = new Shop(1);
            shop.Add(new Smartphone("Samsung", 100));

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(new Smartphone("Samsung", 100));
            });
        }
        [Test]
        public void Test_Add_Phone_Is_Added()
        {
            Shop shop = new Shop(10);
            Assert.AreEqual(0, shop.Count);

            shop.Add(new Smartphone("Samsung", 100));
            Assert.AreEqual(1, shop.Count);
        }
        [Test]
        public void Test_Remove_Throw_Exeption()
        {
            Shop shop = new Shop(10);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Remove("Iphone");
            });
        }
        [Test]
        public void Test_Remove_Phone()
        {
            Shop shop = new Shop(10);
            shop.Add(new Smartphone("Samsung", 100));
            Assert.AreEqual(1, shop.Count);
            shop.Remove("Samsung");
            Assert.AreEqual(0, shop.Count);
        }
        [Test]
        public void Test_TestPhone_Throw_Exeption_If_Dont_Exist()
        {
            Shop shop = new Shop(10);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone("Iphone", 20);
            });
        }
        [Test]
        public void Test_TestPhone_Throw_Exeption_If_Cant_Use_It()
        {
            Shop shop = new Shop(10);
            shop.Add(new Smartphone("Samsung", 45));

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone("Samsung", 70);
            });
        }
        [Test]
        public void Test_TestPhone_Is_Used()
        {
            Type type = typeof(Shop);
            FieldInfo field = type.GetField("phones", BindingFlags.Instance | BindingFlags.NonPublic);

            Shop shop = new Shop(10);
            shop.Add(new Smartphone("Samsung", 100));
            shop.TestPhone("Samsung", 70);

            var phone = field.GetValue(shop) as List<Smartphone>;

            Assert.AreEqual(30, phone.FirstOrDefault(x => x.ModelName == "Samsung").CurrentBateryCharge);
        }

        [Test]
        public void Test_ChargePhone_Throw_Exeption_If_Cant_Charge_It()
        {
            Shop shop = new Shop(10);
            shop.Add(new Smartphone("Samsung", 45));

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.ChargePhone("Iphone");
            });
        }
        [Test]
        public void Test_ChargePhone_Is_Charging()
        {
            Type type = typeof(Shop);
            FieldInfo field = type.GetField("phones", BindingFlags.Instance | BindingFlags.NonPublic);

            Shop shop = new Shop(10);
            shop.Add(new Smartphone("Samsung", 100));
            shop.TestPhone("Samsung", 70);
            shop.ChargePhone("Samsung");

            var phone = field.GetValue(shop) as List<Smartphone>;

            Assert.AreEqual(100, phone.FirstOrDefault(x => x.ModelName == "Samsung").CurrentBateryCharge);
        }
    }
}