﻿using System;
using System.Collections.Generic;
using System.Text;
using Waher.Script;

namespace Waher.Content
{
	/// <summary>
	/// Basic interface for Internet Content decoders. A class implementing this interface and having a default constructor, will be able
	/// to partake in object decodings through the static <see cref="InternetContent"/> class. No registration is required.
	/// </summary>
	public interface IContentDecoder
	{
		/// <summary>
		/// Supported content types.
		/// </summary>
		string[] ContentTypes
		{
			get;
		}

		/// <summary>
		/// Supported file extensions.
		/// </summary>
		string[] FileExtensions
		{
			get;
		}

		/// <summary>
		/// If the decoder decodes an object with a given content type.
		/// </summary>
		/// <param name="ContentType">Content type to decode.</param>
		/// <param name="Grade">How well the decoder decodes the object.</param>
		/// <returns>If the decoder can decode an object with the given type.</returns>
		bool Decodes(string ContentType, out Grade Grade);

		/// <summary>
		/// Decodes an object.
		/// </summary>
		/// <param name="ContentType">Internet Content Type.</param>
		/// <param name="Data">Encoded object.</param>
		/// <param name="Encoding">Any encoding specified. Can be null if no encoding specified.</param>
		/// <returns>Decoded object.</returns>
		/// <exception cref="ArgumentException">If the object cannot be decoded.</exception>
		object Decode(string ContentType, byte[] Data, Encoding Encoding);

	}
}