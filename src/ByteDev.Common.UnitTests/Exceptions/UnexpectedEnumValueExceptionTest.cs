﻿using System;
using ByteDev.Common.Exceptions;
using NUnit.Framework;

namespace ByteDev.Common.UnitTests.Exceptions
{
    [TestFixture]
    public class UnexpectedEnumValueExceptionTest
    {
        private enum Color
        {
            Red
        }

        [TestFixture]
        public class Constructor : UnexpectedEnumValueExceptionTest
        {
            [Test]
            public void WhenNoArgs_ThenSetMessageToDefault()
            {
                var sut = new UnexpectedEnumValueException<Color>();

                Assert.That(sut.Message, Is.EqualTo("Unexpected value for enum 'Color'."));
            }

            [Test]
            public void WhenEnumValueSpecified_ThenSetMessage()
            {
                var sut = new UnexpectedEnumValueException<Color>(Color.Red);

                Assert.That(sut.Message, Is.EqualTo("Unexpected value 'Red' for enum 'Color'."));
            }


            [Test]
            public void WhenMessageAndInnerExSpecified_ThenSetMessageAndInnerEx()
            {
                var innerException = new Exception();

                var sut = new ArgumentNullOrEmptyException("some message.", innerException);

                Assert.That(sut.Message, Is.EqualTo("some message."));
                Assert.That(sut.InnerException, Is.SameAs(innerException));
            }
        }
    }
}