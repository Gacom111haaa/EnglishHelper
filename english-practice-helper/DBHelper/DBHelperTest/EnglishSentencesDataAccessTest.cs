/*
	This code was generated by SQL Compact Code Generator version 1.3.0.7

	SQL Compact Code Generator was written by Christian Resma Helle (http://sqlcecodegen.codeplex.com)
	and is under the GNU General Public License version 2 (GPLv2)

	Generated: 07/13/2013 19:59:21
*/



namespace DBHelperTest
{
    using DBHelper;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EnglishSentencesDataAccessTest : DataAccessTestBase
    {
        [TestMethod]
        public void CreateTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new EnglishSentences
            {
                Content = RandomGenerator.GenerateString(100),
                Level = new System.Random().Next(1, 1000)
            };
            target.Create(actual);
        }

        [TestMethod]
        public void CreateWithParametersTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            target.Create(RandomGenerator.GenerateString(100), new System.Random().Next(1, 1000));
        }

        [TestMethod]
        public void ToListTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.ToList();
            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void ToArrayTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.ToArray();
            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void ToListWithTopTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.ToList(10);
            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void ToArrayWithTopTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.ToArray(10);
            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void SelectByIDTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var record = target.ToList(1)[0];
            var actual = target.SelectByID(record.ID);

            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void SelectByContentTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var record = target.ToList(1)[0];
            var actual = target.SelectByContent(record.Content);

            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void SelectByLevelTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var record = target.ToList(1)[0];
            var actual = target.SelectByLevel(record.Level);

            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void SelectByIDWithTopTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var record = target.ToList(1)[0];
            var actual = target.SelectByID(record.ID, 10);

            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void SelectByContentWithTopTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var record = target.ToList(1)[0];
            var actual = target.SelectByContent(record.Content, 10);

            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void SelectByLevelWithTopTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var record = target.ToList(1)[0];
            var actual = target.SelectByLevel(record.Level, 10);

            Assert.IsNotNull(actual);
            CollectionAssert.AllItemsAreNotNull(actual);
        }

        [TestMethod]
        public void DeleteTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new EnglishSentences
            {
                Content = RandomGenerator.GenerateString(100),
                Level = new System.Random().Next(1, 1000)
            };
            target.Create(actual);
            target.Delete(actual);
        }

        [TestMethod]
        public void DeleteManyTest()
        {
            PopulateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.ToList();
            target.Delete(actual);
        }

        [TestMethod]
        public void DeleteByIDTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new EnglishSentences
            {
                Content = RandomGenerator.GenerateString(100),
                Level = new System.Random().Next(1, 1000)
            };
            target.Create(actual);
            target.DeleteByID(actual.ID);
        }

        [TestMethod]
        public void DeleteByContentTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new EnglishSentences
            {
                Content = RandomGenerator.GenerateString(100),
                Level = new System.Random().Next(1, 1000)
            };
            target.Create(actual);
            target.DeleteByContent(actual.Content);
        }

        [TestMethod]
        public void DeleteByLevelTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new EnglishSentences
            {
                Content = RandomGenerator.GenerateString(100),
                Level = new System.Random().Next(1, 1000)
            };
            target.Create(actual);
            target.DeleteByLevel(actual.Level);
        }

        [TestMethod]
        public void PurgeTest()
        {
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            target.Purge();
            var actual = target.ToList();
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new EnglishSentences
            {
                Content = RandomGenerator.GenerateString(100),
                Level = new System.Random().Next(1, 1000)
            };
            target.Create(actual);

            var actual2 = target.ToList();
            var item = actual2[0];
            item.Content = RandomGenerator.GenerateString(100);
            target.Update(item);
        }

        [TestMethod]
        public void UpdateManyTest()
        {
            PopulateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.ToList();
            target.Update(actual);
        }

        [TestMethod]
        public void PopulateTest()
        {
            PurgeTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = new System.Collections.Generic.List<EnglishSentences>();
            for (int i = 0; i < 10; i++)
                actual.Add(new EnglishSentences
                {
                    Content = RandomGenerator.GenerateString(100),
                    Level = new System.Random().Next(1, 1000)
                });
            target.Create(actual);
        }

        [TestMethod]
        public void CountTest()
        {
            CreateTest();
            IEnglishSentencesRepository target = new EnglishSentencesRepository();
            var actual = target.Count();
            Assert.AreNotEqual(0, actual);
        }

    }
}

