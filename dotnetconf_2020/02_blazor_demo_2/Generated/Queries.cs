﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            53,
            102,
            54,
            48,
            55,
            54,
            49,
            57,
            102,
            49,
            102,
            56,
            99,
            52,
            53,
            57,
            97,
            48,
            57,
            57,
            48,
            49,
            97,
            57,
            98,
            57,
            101,
            97,
            53,
            56,
            49,
            55
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            71,
            101,
            116,
            80,
            101,
            111,
            112,
            108,
            101,
            32,
            123,
            32,
            112,
            101,
            111,
            112,
            108,
            101,
            40,
            111,
            114,
            100,
            101,
            114,
            95,
            98,
            121,
            58,
            32,
            123,
            32,
            110,
            97,
            109,
            101,
            58,
            32,
            65,
            83,
            67,
            32,
            125,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            111,
            100,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            101,
            109,
            97,
            105,
            108,
            32,
            105,
            115,
            79,
            110,
            108,
            105,
            110,
            101,
            32,
            105,
            109,
            97,
            103,
            101,
            85,
            114,
            105,
            32,
            108,
            97,
            115,
            116,
            83,
            101,
            101,
            110,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query GetPeople {
              people(order_by: { name: ASC }) {
                nodes {
                  name
                  email
                  isOnline
                  imageUri
                  lastSeen
                }
              }
            }";
    }
}
