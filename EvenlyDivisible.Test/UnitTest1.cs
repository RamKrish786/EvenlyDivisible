using EvenlyDivisible.Test;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace Tests
{
    public class Tests
    {        
        //Since project is a console application need to refactor the lines of code that call Console.ReadLine into a separate object, hence created Mock.
        public MockProgram MockObj { get;  set; }
        [SetUp]
        public void Setup()
        {
            MockObj = new MockProgram();
        }        

        [Test]
        public void GivenMaxValueAsLowerThanMinValue_ThenGivenInputRangeIsInvalid()
        {
            MockInput obj = new MockInput();
            MockObj.Main("5", "1", "2", "8", obj);            
            Assert.That(obj.IsValid,Is.EqualTo(false));
            Assert.That(obj.ErrorMessage, Is.EqualTo("Not a valid Min and Max value"));
        }
        [Test]
        public void GivenMinValueIsNotAValidNumber_ThenGivenInputIsInvalid()
        {
            MockInput obj = new MockInput();
            MockObj.Main("0.05", "1", "2", "8", obj);
            Assert.That(obj.IsValid, Is.EqualTo(false));
            Assert.That(obj.ErrorMessage, Is.EqualTo("Not a valid Min value"));
        }
        [Test]
        public void GivenMaxValueIsNotAValidNumber_ThenGivenInputIsInvalid()
        {
            MockInput obj = new MockInput();
            MockObj.Main("5", "1.2", "2", "8", obj);
            Assert.That(obj.IsValid, Is.EqualTo(false));
            Assert.That(obj.ErrorMessage, Is.EqualTo("Not a valid Max value"));
        }
        [Test]
        public void GivenFirstDivisibleValueIsNotAValidNumber_ThenGivenInputIsInvalid()
        {
            MockInput obj = new MockInput();
            MockObj.Main("5", "10", "2.2", "8", obj);
            Assert.That(obj.IsValid, Is.EqualTo(false));
            Assert.That(obj.ErrorMessage, Is.EqualTo("Not a valid first Divisible value"));
        }
        [Test]
        public void GivenSecondDivisibleValueIsNotAValidNumber_ThenGivenInputIsInvalid()
        {
            MockInput obj = new MockInput();
            MockObj.Main("5", "10", "2", "8.5", obj);
            Assert.That(obj.IsValid, Is.EqualTo(false));
            Assert.That(obj.ErrorMessage, Is.EqualTo("Not a valid second Divisible value"));
        }
        [Test]
        public void GivenInputsAreValidNumber_ThenIsValidisTrue()
        {
            MockInput obj = new MockInput();
            MockObj.Main("5", "10", "2", "8", obj);
            Assert.That(obj.IsValid, Is.EqualTo(true));           
        }
        [Test]
        public void GivenMinAsFiveAndMaxAsTen_DivisibleAsTwoAndFour_ThenFencyCountIsTwo_FencyPantsCountIsOne_PantsCountIsZero()
        {
            MockInput obj = new MockInput();
            MockObj.Main("5", "10", "2", "4", obj);
            Assert.That(obj.IsValid, Is.EqualTo(true));
            Assert.That(obj.FancyCount, Is.EqualTo(2));
            Assert.That(obj.FancyPantsCount, Is.EqualTo(1));
            Assert.That(obj.PantsCount, Is.EqualTo(0));
        }
    }
}