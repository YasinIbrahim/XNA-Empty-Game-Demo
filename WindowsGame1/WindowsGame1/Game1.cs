using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GameTest
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont Font1;
        Vector2 FontPos;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            //Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            
            ResourceContentManager Content = new ResourceContentManager(this.Services, Resource1.ResourceManager);

            //Font1 = content1.Load<SpriteFont>("Arial");
            Font1 = Content.Load<SpriteFont>("Arial");

            // TODO: use this.Content to load your game content here
            FontPos = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2,
                graphics.GraphicsDevice.Viewport.Height / 2);

  
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))

                this.Exit();

            // TODO: Add your update logic here



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            //if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                GraphicsDevice.Clear(Color.DarkOrchid);

                spriteBatch.Begin();
                // Draw Hello World
                string output = "Testing message";
                // Find the center of the string
                Vector2 FontOrigin = Font1.MeasureString(output) / 2;
                // Draw the string
                spriteBatch.DrawString(Font1, output, FontPos, Color.LightGreen, 0, FontOrigin, 1.0f, SpriteEffects.None, 0.5f);
                spriteBatch.End();
            }
            /*
            else if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {

            }
            */
            else
            {

                GraphicsDevice.Clear(Color.Crimson);
                spriteBatch.Begin();
                // Draw Hello World
                string spaceMsg = "press and hold space bar";
                // Find the center of the string
                Vector2 FontOrigin1 = Font1.MeasureString(spaceMsg) / 2;
                // Draw the string
                spriteBatch.DrawString(Font1, spaceMsg, FontPos, Color.LightGreen, 0, FontOrigin1, 1.0f, SpriteEffects.None, 0.5f);
                spriteBatch.End();
            }
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
