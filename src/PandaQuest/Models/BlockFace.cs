﻿using Microsoft.Xna.Framework.Graphics;

namespace PandaQuest.Models;

public sealed class BlockFace
{
    public readonly VertexPositionTexture[] Vertices;

    public BlockFace(params VertexPositionTexture[] vertices)
    {
        this.Vertices = vertices;
    }
}
