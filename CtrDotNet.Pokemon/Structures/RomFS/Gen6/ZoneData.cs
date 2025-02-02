﻿using System;
using System.IO;
using CtrDotNet.Pokemon.Game;

namespace CtrDotNet.Pokemon.Structures.RomFS.Gen6
{
	public class ZoneData : BaseDataStructure
	{
		#region Static

		public class Entry : BaseDataStructure
		{
			public const int Size = 0x38;
			private const int IdOffset = 0x1C;

			public Entry( GameVersion gameVersion ) : base( gameVersion ) { }

			public ushort ZoneId { get; set; }

			protected override void ReadData( BinaryReader br )
			{
				br.BaseStream.Seek( IdOffset, SeekOrigin.Begin );
				this.ZoneId = (ushort) ( br.ReadUInt16() & 0x1FF );
			}
		}

		#endregion

		public ZoneData( GameVersion gameVersion ) : base( gameVersion ) { }

		public Entry[] Entries { get; set; }

		public override byte[] Write() => throw new NotSupportedException( "Writing not supported" );

		protected override void ReadData( BinaryReader br )
		{
			int numEntries = (int) ( br.BaseStream.Length / Entry.Size );
			this.Entries = new Entry[ numEntries ];

			for ( int i = 0; i < numEntries; i++ )
			{
				byte[] entryBuffer = new byte[ Entry.Size ];
				br.Read( entryBuffer, 0, entryBuffer.Length );
				this.Entries[ i ] = new Entry( this.GameVersion );
				this.Entries[ i ].Read( entryBuffer );
			}
		}
	}
}