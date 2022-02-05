﻿using FlatSharp.Attributes;

// ReSharper disable UnusedMember.Global

namespace pkNX.Structures.FlatBuffers;

[FlatBufferEnum(typeof(ulong))]
public enum Condition8a : ulong
{
    GreaterThanEqual = 0x34F605C97C571896,
    LessThanEqual = 0x488B1F9FBC949365,
    NotEqual = 0x88C99E99F1FC6C55,
    Equal = 0xB763CBE88B6F844F,
    None = 0xCBF29CE484222645,
    Between = 0xE5E34D77DC75E2EF,
}
