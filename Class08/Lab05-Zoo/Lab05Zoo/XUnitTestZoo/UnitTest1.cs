using Classes;
using System;
using Xunit;
using static Classes.Program;

namespace XUnitTestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TestDip()
        {
            Diplodocus newDip = new Diplodocus();
            Assert.False(newDip.Run());
        }

        [Fact]
        public void TestDip2()
        {
            Diplodocus newDip = new Diplodocus();
            Assert.True(newDip.Ride());
        }
        [Fact]
        public void TestCor()
        {
            Corythosaurous newCor = new Corythosaurous();
            Assert.True(newCor.Eat());
        }

        [Fact]
        public void TestCor2()
        {
            Corythosaurous newCor = new Corythosaurous();
            Assert.True(newCor.Terrorizing());
        }

        [Fact]
        public void TestSteg()
        {
            Stegosaurus newSteg = new Stegosaurus();
            Assert.True(newSteg.Chillin());
        }

        [Fact]
        public void TestSteg2()
        {
            Stegosaurus newSteg = new Stegosaurus();
            Assert.False(newSteg.Eat());
        }

        [Fact]
        public void TestTee()
        {
            Trex newTee = new Trex();
            Assert.True(newTee.Terrorizing()); ;
        }

        [Fact]
        public void TestTee2()
        {
            Trex newTee = new Trex();
            Assert.True(newTee.Run());
        }

        [Fact]
        public void TestOm()
        {
            OmviRaptor newOm = new OmviRaptor();
            Assert.False(newOm.Run());
        }

        [Fact]
        public void TestOm2()
        {
            OmviRaptor newOm = new OmviRaptor();
            Assert.True(newOm.Chillin());
        }

        [Fact]
        public void TestParent()
        {
            OmviRaptor newOm = new OmviRaptor();
            Assert.True(newOm is Dinosaurs);
        }


    }

}
