using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using MPP_2.Exceptions;
using MPP_2.MyFaker;

namespace Tests.FakerTests
{
    [TestClass]
    public class FakerTest
    {
        [TestMethod]
        public void CycleDetectionTest()
        {
            Action action = () =>
            {
                Faker f = new Faker();
                f.Create<CycleTestClass>();
            };
            action.Should().Throw<CyclicDependenceException>();
        }

        [TestMethod]
        public void ConstructorSelectionTest()
        {
            Faker f = new Faker();
            ConstructorClass obj = f.Create<ConstructorClass>();
            obj.Check();
        }

        [TestMethod]
        public void CommonClassTest()
        {
            Faker f = new Faker();
            CommonClass obj = f.Create<CommonClass>();
            Type type = typeof(CommonClass);
            obj.f1.Should().NotBe(float.NaN);
            obj.p1.Should().NotBe(float.NaN);
            foreach (var list in obj.list)
            {
                list.Should().NotBeNull();
                foreach (var elemet in list)
                {
                    elemet.Should().NotBeNull();
                    elemet.f1.Should().NotBe(float.NaN);
                    elemet.f2.Should().NotBe(float.NaN);
                }
            }
        }
    }
}