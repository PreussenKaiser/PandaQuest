﻿using Microsoft.Xna.Framework;
using Panda.Extensions;
using Panda.Noise.Abstractions;
using PandaQuest.Configuration;
using PandaQuest.Models;

namespace PandaQuest.Extensions;

public static class NoiseExtensions
{
	public static BlockIndex GetBlockIndex(this INoise2 noise, Vector3 position, WorldConfiguration configuration)
	{
		float value = noise.GetValue(position.X, position.Z);
		float surfaceY = value.Scale(configuration.WorldHeight);

		var index = position.Y < surfaceY ? BlockIndex.Dirt : BlockIndex.Air;

		return index;
	}
}
