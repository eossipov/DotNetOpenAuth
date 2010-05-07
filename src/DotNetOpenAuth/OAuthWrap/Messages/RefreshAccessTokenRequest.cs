﻿//-----------------------------------------------------------------------
// <copyright file="RefreshAccessTokenRequest.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuthWrap.Messages {
	using System;
	using DotNetOpenAuth.Messaging;

	/// <summary>
	/// A request from the client to the token endpoint for a new access token
	/// in exchange for a refresh token that the client has previously obtained.
	/// </summary>
	internal class RefreshAccessTokenRequest : MessageBase {
		/// <summary>
		/// Initializes a new instance of the <see cref="RefreshAccessTokenRequest"/> class.
		/// </summary>
		/// <param name="tokenEndpoint">The token endpoint.</param>
		/// <param name="version">The version.</param>
		internal RefreshAccessTokenRequest(Uri tokenEndpoint, Version version)
			: base(version, MessageTransport.Direct, tokenEndpoint) {
		}

		/// <summary>
		/// Gets or sets the identifier by which this client is known to the Authorization Server.
		/// </summary>
		/// <value>The client identifier.</value>
		[MessagePart(Protocol.client_id, IsRequired = true, AllowEmpty = false)]
		internal string ClientIdentifier { get; set; }

		/// <summary>
		/// Gets or sets the client secret.
		/// </summary>
		/// <value>The client secret.</value>
		/// <remarks>
		/// REQUIRED if the client identifier has a matching secret. The client secret as described in Section 3.4  (Client Credentials). 
		/// </remarks>
		[MessagePart(Protocol.client_secret, IsRequired = false, AllowEmpty = true)]
		internal string ClientSecret { get; set; }

		/// <summary>
		/// Gets or sets the refresh token.
		/// </summary>
		/// <value>The refresh token.</value>
		/// <remarks>
		/// REQUIRED. The refresh token associated with the access token to be refreshed. 
		/// </remarks>
		[MessagePart(Protocol.refresh_token, IsRequired = true, AllowEmpty = false)]
		internal string RefreshToken { get; set; }

		/// <summary>
		/// Gets or sets the type of the secret.
		/// </summary>
		/// <value>The type of the secret.</value>
		/// <remarks>
		/// OPTIONAL. The access token secret type as described by Section 5.3  (Cryptographic Tokens Requests). If omitted, the authorization server will issue a bearer token (an access token without a matching secret) as described by Section 5.2  (Bearer Token Requests). 
		/// </remarks>
		[MessagePart(Protocol.secret_type, IsRequired = false, AllowEmpty = false)]
		internal string SecretType { get; set; }
	}
}
