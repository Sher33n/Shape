using System;
using NUnit.Framework;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ShapeTest
	{
		[Test ()]
		public void TestShapeAt(){
			Shape s = new Shape ();
			s.X = 25;
			s.Y = 25;
			s.Width =50;
			s.Height=50;

			Assert.IsTrue(s.IsAt(SwinGame.PointAt(50,50)));
			Assert.IsTrue(s.IsAt(SwinGame.PointAt(25,25)));
			Assert.IsFalse(s.IsAt(SwinGame.PointAt(10,50)));
			Assert.IsFalse(s.IsAt(SwinGame.PointAt(50,10)));
		}

		[Test ()]
		public void TestShapeAtWhenMoved(){
			Shape s = new Shape ();
			s.X = 25;
			s.Y = 25;
			s.Width =50;
			s.Height=50;

			Assert.IsTrue(s.IsAt(SwinGame.PointAt(50,50)));
			Assert.IsTrue(s.IsAt(SwinGame.PointAt(25,25)));
			Assert.IsFalse(s.IsAt(SwinGame.PointAt(10,50)));
			Assert.IsFalse(s.IsAt(SwinGame.PointAt(50,10)));
		}
	}
}

