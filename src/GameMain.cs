using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            //SwinGame.ShowSwinGameSplashScreen();
            
			//create a shape object
			Shape myShape = new Shape();
		
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);

				//Tell myShape to Draw itself
				myShape.Draw();

				if (SwinGame.MouseClicked (MouseButton.LeftButton)) // if left clciked on mouse = true
				{
					//update X & Y
					myShape.X = SwinGame.MouseX();
					myShape.Y = SwinGame.MouseY();
				}
				//change the color of the shape
				// if mouse position is on the shape && space bar is press
				if (myShape.IsAt(SwinGame.MousePosition()) && SwinGame.KeyTyped(KeyCode.vk_SPACE))
				{
					myShape.Color = SwinGame.RandomRGBColor(255);
				}

                SwinGame.DrawFramerate(0,0);
                
                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}
