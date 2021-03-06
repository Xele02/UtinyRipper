﻿using System.Collections.Generic;
using UtinyRipper.Classes;

namespace UtinyRipper.SerializedFiles
{
	public interface ISerializedFile
	{
		/// <summary>
		/// Get asset from current serialized file
		/// </summary>
		/// <param name="fileIndex">Path ID for searching object</param>
		/// <returns>Found object</returns>
		Object GetAsset(long pathID);
		/// <summary>
		/// Get asset in serialized file with specified file index
		/// </summary>
		/// <param name="fileIndex">Dependency index</param>
		/// <param name="pathID">Path ID for searching object</param>
		/// <returns>Found object</returns>
		Object GetAsset(int fileIndex, long pathID);
		/// <summary>
		/// Try to find asset from current assets file
		/// </summary>
		/// <param name="pathID">Path ID for searching object</param>
		/// <returns>Found object or null</returns>
		Object FindAsset(long pathID);
		/// <summary>
		/// Try to find asset in serialized file with specified file index
		/// </summary>
		/// <param name="fileIndex">Dependency index</param>
		/// <param name="pathID">Path ID for searching object</param>
		/// <returns>Found object or null</returns>
		Object FindAsset(int fileIndex, long pathID);

		AssetEntry GetAssetEntry(long pathID);
		ClassIDType GetClassID(long pathID);
		
		IEnumerable<Object> FetchAssets();

		string Name { get; }
		Platform Platform { get; }
		Version Version { get; }
		TransferInstructionFlags Flags { get; }

		bool IsScene { get; }

		IFileCollection Collection { get; }
		IReadOnlyList<FileIdentifier> Dependencies { get; }
	}
}
