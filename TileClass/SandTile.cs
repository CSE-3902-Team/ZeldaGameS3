﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint0.TileClass
{
	public class SandTile : ITile, IBoxCollider
	{
        private Vector2 myPos;
		private Texture2D myTile;
		private SpriteBatch myBatch;
        private Rectangle sourceRect;
        private Rectangle collisionBox;

        public Rectangle CollisionBox { get { return collisionBox; } set { collisionBox = value; } }
		public SandTile(Texture2D tile, SpriteBatch batch, Vector2 position)
        {
			myTile = tile;
			myBatch = batch;
            myPos = position;
            sourceRect = new Rectangle(0, 0, 32, 32);
            collisionBox = sourceRect;
        }
		public void draw()
		{
            Rectangle destinationRectangle = new Rectangle((int)myPos.X, (int)myPos.Y, 90, 90);
            myBatch.Begin();
            myBatch.Draw(
                 myTile,
                 destinationRectangle,
                 sourceRect,
                Color.White,
                0f,
                new Vector2(sourceRect.Width / 2, sourceRect.Height / 2),
                SpriteEffects.None,
                0f
                );
            myBatch.End();
        }

        public Texture2D Texture
        {
            get { return this.myTile; }
            set { myTile = value; }
        }

        public float Speed
        {
            get;
            set;
        }

        public Vector2 Position
        {
            get;
            set;
        }
    }

}