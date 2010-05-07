﻿// <auto-generated/> // disable StyleCop on this file
//-----------------------------------------------------------------------
// <copyright file="Protocol.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuthWrap {
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// An enumeration of the OAuth WRAP protocol versions supported by this library.
	/// </summary>
	public enum ProtocolVersion {
		/// <summary>
		/// The OAuth 2.0 specification.
		/// </summary>
		V20,
	}

	/// <summary>
	/// Protocol constants for OAuth WRAP.
	/// </summary>
	internal class Protocol {
		/// <summary>
		/// The HTTP authorization scheme "WRAP";
		/// </summary>
		internal const string HttpAuthorizationScheme = "WRAP";

		/// <summary>
		/// The format of the HTTP Authorization header value that authorizes OAuth WRAP requests.
		/// </summary>
		internal const string HttpAuthorizationHeaderFormat = "WRAP access_token=\"{0}\"";

		/// <summary>
		/// The "type" string.
		/// </summary>
		internal const string type = "type";

		/// <summary>
		/// The "state" string.
		/// </summary>
		internal const string state = "state";

		/// <summary>
		/// The "redirect_uri" string.
		/// </summary>
		internal const string redirect_uri = "redirect_uri";

		/// <summary>
		/// The "client_id" string.
		/// </summary>
		internal const string client_id = "client_id";

		/// <summary>
		/// The "wrap_scope" string.
		/// </summary>
		internal const string wrap_scope = "wrap_scope";

		/// <summary>
		/// The "immediate" string.
		/// </summary>
		internal const string immediate = "immediate";

		/// <summary>
		/// The "client_secret" string.
		/// </summary>
		internal const string client_secret = "client_secret";

		/// <summary>
		/// The "wrap_verification_code" string.
		/// </summary>
		internal const string code = "code";

		/// <summary>
		/// The "wrap_verification_url" string.
		/// </summary>
		internal const string wrap_verification_url = "wrap_verification_url";

		/// <summary>
		/// The "error" string.
		/// </summary>
		internal const string error = "error";

		/// <summary>
		/// The "access_token" string.
		/// </summary>
		internal const string access_token = "access_token";

		/// <summary>
		/// The "access_token_secret" string.
		/// </summary>
		internal const string access_token_secret = "access_token_secret";

		/// <summary>
		/// The "refresh_token" string.
		/// </summary>
		internal const string refresh_token = "refresh_token";

		/// <summary>
		/// The "expires_in" string.
		/// </summary>
		internal const string expires_in = "expires_in";

		/// <summary>
		/// The "expired_delegation_code" string.
		/// </summary>
		internal const string expired_delegation_code = "expired_delegation_code";

		/// <summary>
		/// The "wrap_username" string.
		/// </summary>
		internal const string wrap_username = "wrap_username";

		/// <summary>
		/// The "wrap_password" string.
		/// </summary>
		internal const string wrap_password = "wrap_password";

		/// <summary>
		/// The "wrap_name" string.
		/// </summary>
		internal const string wrap_name = "wrap_name";

		/// <summary>
		/// The "wrap_assertion_format" string.
		/// </summary>
		internal const string wrap_assertion_format = "wrap_assertion_format";

		/// <summary>
		/// The "wrap_assertion" string.
		/// </summary>
		internal const string wrap_assertion = "wrap_assertion";

		/// <summary>
		/// The "wrap_SAML" string.
		/// </summary>
		internal const string wrap_saml = "wrap_SAML";

		/// <summary>
		/// The "wrap_SWT" string.
		/// </summary>
		internal const string wrap_swt = "wrap_SWT";

		/// <summary>
		/// The "wrap_captcha_url" string.
		/// </summary>
		internal const string wrap_captcha_url = "wrap_captcha_url";

		/// <summary>
		/// The "wrap_captcha_solution" string.
		/// </summary>
		internal const string wrap_captcha_solution = "wrap_captcha_solution";

		/// <summary>
		/// The "user_denied" string.
		/// </summary>
		internal const string user_denied = "user_denied";

		/// <summary>
		/// The "secret_type" string.
		/// </summary>
		internal const string secret_type = "secret_type";

		/// <summary>
		/// Gets the <see cref="Protocol"/> instance with values initialized for V1.0 of the protocol.
		/// </summary>
		internal static readonly Protocol V20 = new Protocol {
			Version = new Version(2, 0),
			ProtocolVersion = ProtocolVersion.V20,
		};

		/// <summary>
		/// A list of all supported OAuth versions, in order starting from newest version.
		/// </summary>
		internal static readonly List<Protocol> AllVersions = new List<Protocol>() { V20 };

		/// <summary>
		/// The default (or most recent) supported version of the OpenID protocol.
		/// </summary>
		internal static readonly Protocol Default = AllVersions[0];

		/// <summary>
		/// Gets or sets the OAuth WRAP version represented by this instance.
		/// </summary>
		/// <value>The version.</value>
		internal Version Version { get; private set; }

		/// <summary>
		/// Gets or sets the OAuth WRAP version represented by this instance.
		/// </summary>
		/// <value>The protocol version.</value>
		internal ProtocolVersion ProtocolVersion { get; private set; }

		/// <summary>
		/// Gets the OAuth Protocol instance to use for the given version.
		/// </summary>
		/// <param name="version">The OAuth version to get.</param>
		/// <returns>A matching <see cref="Protocol"/> instance.</returns>
		public static Protocol Lookup(ProtocolVersion version) {
			switch (version) {
				case ProtocolVersion.V20: return Protocol.V20;
				default: throw new ArgumentOutOfRangeException("version");
			}
		}
	}
}
