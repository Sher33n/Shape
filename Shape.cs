using System;
using SwinGameSDK;

namespace MyGame
{
	public class Shape
	{
		//field
		private Color _color;
		private float _x, _y;
		private int _width, _height;

		//Constructor
		public Shape ()
		{
			//set default value for the field
			_color = Color.Green;
			_x = 0;
			_y = 0;
			_width = 100;
			_height = 100;
		}
		//Properties
		public Color Color{
			get{ 
				return _color;
			}
			set{
				_color = value;
			}
		}

		public float X{
			get{ 
				return _x;
			}
			set{
				_x = value;
			}
		}

		public float Y{
			get{ 
				return _y;
			}
			set{
				_y = value;
			}
		}

		public int Width{
			get{ 
				return _width;
			}
			set{
				_width = value;
			}
		}

		public int Height{
			get{ 
				return _height;
			}
			set{
				_height = value;
			}
		}
		//Method 1 : Draw
		//if no need return value just use void
		public void Draw(){
			SwinGame.FillRectangle (_color, _x, _y, _width, _height);
		}

		//Method 2 : IsAt. Checks wether a coordinate overlaps
		public bool IsAt(Point2D pt)
		{
			return SwinGame.PointInRect (pt, _x, _y, _width, _height);
			//public static bool PointInRect(Point2D pt, float x, float y, float w, float h) in swinGame
		}

		public void Move()
		{
			X +=1; 
		}
	}
}

