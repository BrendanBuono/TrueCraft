﻿using System;
using TrueCraft.API.Logic;
using fNbt;

namespace TrueCraft.API.World
{
    // TODO: Entities
    /// <summary>
    /// An in-game world composed of chunks and blocks.
    /// </summary>
    public interface IWorld
    {
        string Name { get; set; }
        IBlockRepository BlockRepository { get; set; }
        int Seed { get; set; }
        IBiomeMap BiomeDiagram { get; set; }
        IChunkProvider ChunkProvider { get; set; }
        Coordinates3D SpawnPoint { get; set; }
        long Time { get; set; }

        event EventHandler<BlockChangeEventArgs> BlockChanged;

        IChunk GetChunk(Coordinates2D coordinates);
        byte GetBlockID(Coordinates3D coordinates);
        byte GetMetadata(Coordinates3D coordinates);
        byte GetSkyLight(Coordinates3D coordinates);
        NbtCompound GetTileEntity(Coordinates3D coordinates);
        BlockDescriptor GetBlockData(Coordinates3D coordinates);
        void SetBlockData(Coordinates3D coordinates, BlockDescriptor block);
        void SetBlockID(Coordinates3D coordinates, byte value);
        void SetMetadata(Coordinates3D coordinates, byte value);
        void SetSkyLight(Coordinates3D coordinates, byte value);
        void SetBlockLight(Coordinates3D coordinates, byte value);
        void SetTileEntity(Coordinates3D coordinates, NbtCompound value);
        bool IsValidPosition(Coordinates3D position);
        void Save();
        void Save(string path);
    }
}