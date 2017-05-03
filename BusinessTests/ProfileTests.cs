﻿using Data;
using Entity;
using NUnit.Framework;

namespace BusinessTests
{
    [TestFixture]
    public class ProfileTests
    {
        [Test]
        public void Add()
        {
            ProfileManager manager = new ProfileManager();
            var result = manager.Add(new Profile()
            {
                Email = "test@gmail.com",
                FullName = "Amr Swalha",
                Mobile = "555555",
                Phone = "555555"
            });
            Assert.NotNull(result);
        }
        [Test]
        public void Update()
        {
            ProfileManager manager = new ProfileManager();
            var result = manager.Update(new Profile()
            {
                Id = 1,
                Email = "new@gmail.com",
                FullName = "new Amr Swalha",
                Mobile = "new",
                Phone = "new"
            });
            Assert.NotNull(result);
        }
        [Test]
        public void Delete()
        {
            ProfileManager manager = new ProfileManager();
            var result = manager.Delete(new Profile()
            {
                Id = 1
            });
            Assert.NotNull(result);
        }
        [Test]
        public void FindById()
        {
            ProfileManager manager = new ProfileManager();
            var result = manager.FindById(2);
            Assert.NotNull(result);
        }
        [Test]
        public void FindAll()
        {
            ProfileManager manager = new ProfileManager();
            var result = manager.FindAll();
            Assert.Greater(result.Count, 0);
            Assert.NotNull(result);
        }
        [Test]
        public void FindAllCondition()
        {
            ProfileManager manager = new ProfileManager();
            var result = manager.FindAll("where Id > 2");
            Assert.Greater(result.Count, 0);
            Assert.NotNull(result);
        }
    }
}