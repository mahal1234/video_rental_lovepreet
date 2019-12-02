using Microsoft.VisualStudio.TestTools.UnitTesting;
using video_rental_lovepreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_rental_lovepreet.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj_Form = new Form1();

        }
        [TestMethod()]
        public void RentalTest()
        {
            RentalData obj_Form = new RentalData();

        }

        [TestMethod()]
        public void VideoTest()
        {
            videoData obj_Form = new videoData();

        }

        [TestMethod()]
        public void MemberTest()
        {
            MemberData obj_Form = new MemberData();

        }



    }
}