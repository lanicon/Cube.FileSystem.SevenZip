﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
/* ------------------------------------------------------------------------- */
using Cube.Mixin.String;

namespace Cube.FileSystem.SevenZip
{
    /* --------------------------------------------------------------------- */
    ///
    /// PasswordQuery
    ///
    /// <summary>
    /// Provides functionality to request the password.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    internal class PasswordQuery : IQuery<string>
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// PasswordQuery
        ///
        /// <summary>
        /// Initializes a new instance of the PasswordQuery class with the
        /// specified value.
        /// </summary>
        ///
        /// <param name="password">Password result of the request.</param>
        ///
        /// <remarks>
        /// 実行前に既にパスワードを把握している場合に使用します。
        /// コンストラクタでパスワードを指定した場合、Request の結果は
        /// 常にこの値が設定されます。
        /// </remarks>
        ///
        /* ----------------------------------------------------------------- */
        public PasswordQuery(string password)
        {
            Password = password;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// PasswordQuery
        ///
        /// <summary>
        /// Initializes a new instance of the PasswordQuery class with the
        /// specified object.
        /// </summary>
        ///
        /// <param name="inner">Object to request the password.</param>
        ///
        /* ----------------------------------------------------------------- */
        public PasswordQuery(IQuery<string> inner)
        {
            InnerQuery = inner;
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Password
        ///
        /// <summary>
        /// Gets the password.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public string Password { get; private set; }

        /* ----------------------------------------------------------------- */
        ///
        /// InnerQuery
        ///
        /// <summary>
        /// Gets the query to invokes the password request.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public IQuery<string> InnerQuery { get; private set; }

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Request
        ///
        /// <summary>
        /// Requests the password.
        /// </summary>
        ///
        /// <param name="e">Message to request the password.</param>
        ///
        /* ----------------------------------------------------------------- */
        public void Request(QueryMessage<string, string> e)
        {
            if (Password.HasValue() || _cache.HasValue())
            {
                e.Value  = Password.HasValue() ? Password : _cache;
                e.Cancel = false;
            }
            else
            {
                InnerQuery?.Request(e);
                if (!e.Cancel && e.Value.HasValue()) _cache = e.Value;
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Reset
        ///
        /// <summary>
        /// Resets inner condition.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public void Reset()
        {
            _cache = null;
        }

        #endregion

        #region Fields
        private string _cache;
        #endregion
    }
}