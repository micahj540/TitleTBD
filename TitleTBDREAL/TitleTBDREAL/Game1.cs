using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TitleTBDREAL.Core;
using TitleTBDREAL.Sprites;

namespace TitleTBDREAL
{
    public class Game1 : Game
    {
        
        private Map myMap;
        private MapTrees mapTrees;

        private Player _player;
        private Camera _camera;
        private List<Component> _components;

        public static int ScreenHeight;
        public static int ScreenWidth;

        Texture2D pineTree;
        Texture2D grassTile;
        Texture2D pathTile;
        Texture2D tent;
        Texture2D halfPath;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            ScreenHeight = _graphics.PreferredBackBufferHeight;
            ScreenWidth = _graphics.PreferredBackBufferWidth;

            mapTrees = new MapTrees();
            myMap = new Map(1000, 1000, 100, 100);

            _graphics.IsFullScreen = true;
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _camera = new Camera();
            _player = new Player(Content.Load<Texture2D>("mainCharacter"));
            

            grassTile = Content.Load<Texture2D>("GrassTile");
            pineTree = Content.Load<Texture2D>("pineTree");
            pathTile = Content.Load<Texture2D>("PathTile");
            tent = Content.Load<Texture2D>("VaginaTent");
            halfPath = Content.Load<Texture2D>("PathGrassTile");

            _components = new List<Component>()
            {
                new Sprite(Content.Load<Texture2D>("GrassTile")), _player,
                new Sprite(Content.Load<Texture2D>("pineTree"))
            };


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach(var component in _components)
            {
                component.Update(gameTime);
            }
            _camera.follow(_player);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            _spriteBatch.Begin(transformMatrix: _camera.Transform);

            myMap.drawGrass(_spriteBatch, grassTile);
            myMap.drawPath(_spriteBatch, pathTile, halfPath);
            mapTrees.draw(_spriteBatch, pineTree);
            myMap.drawHouse(_spriteBatch, tent);

            foreach(var component in _components)
            {
                component.Draw(gameTime, _spriteBatch);
            }
       
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}