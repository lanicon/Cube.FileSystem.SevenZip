﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using System.Linq;

namespace Cube.FileSystem.SevenZip
{
    /* --------------------------------------------------------------------- */
    ///
    /// SevenZipOptionSetter
    ///
    /// <summary>
    /// 7Z 圧縮ファイルのオプション項目を設定するためのクラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    internal class SevenZipOptionSetter : ArchiveOptionSetter
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// SevenZipOptionSetter
        ///
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="option">オプション</param>
        ///
        /* ----------------------------------------------------------------- */
        public SevenZipOptionSetter(ArchiveOption option) : base(option) { }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// SupportedMethods
        ///
        /// <summary>
        /// 設定可能な圧縮方法一覧を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static CompressionMethod[] SupportedMethods => new[]
        {
            CompressionMethod.Lzma,
            CompressionMethod.Lzma2,
            CompressionMethod.Ppmd,
            CompressionMethod.BZip2,
            CompressionMethod.Deflate,
            CompressionMethod.Copy,
        };

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Execute
        ///
        /// <summary>
        /// オプションをアーカイブ・オブジェクトに設定します。
        /// </summary>
        ///
        /// <param name="dest">アーカイブ・オブジェクト</param>
        ///
        /* ----------------------------------------------------------------- */
        public override void Execute(ISetProperties dest)
        {
            if (Option is SevenZipOption so)
            {
                AddCompressionMethod(so);
            }
            base.Execute(dest);
        }

        #endregion

        #region Implementations

        /* ----------------------------------------------------------------- */
        ///
        /// AddCompressionMethod
        ///
        /// <summary>
        /// 圧縮方式を追加します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void AddCompressionMethod(SevenZipOption so)
        {
            var value = so.CompressionMethod;
            if (!SupportedMethods.Contains(value)) return;
            Add("0", PropVariant.Create(value.ToString()));
        }

        #endregion
    }
}
