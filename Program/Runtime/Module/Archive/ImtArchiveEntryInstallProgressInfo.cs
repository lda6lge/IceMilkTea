﻿// zlib/libpng License
//
// Copyright (c) 2018 Sinoa
//
// This software is provided 'as-is', without any express or implied warranty.
// In no event will the authors be held liable for any damages arising from the use of this software.
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it freely,
// subject to the following restrictions:
//
// 1. The origin of this software must not be misrepresented; you must not claim that you wrote the original software.
//    If you use this software in a product, an acknowledgment in the product documentation would be appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.

namespace IceMilkTea.Module
{
    /// <summary>
    /// アーカイブのエントリインストール進行情報を保持した構造体です
    /// </summary>
    public struct ImtArchiveEntryInstallProgressInfo
    {
        /// <summary>
        /// 担当するインストーラ
        /// </summary>
        public ImtArchiveEntryInstaller Installer { get; private set; }

        /// <summary>
        /// 今回のインストーラを含め、残りのインストールする数
        /// </summary>
        public int RemainingInstallCount { get; private set; }



        /// <summary>
        /// ImtArchiveEntryInstallProgressInfo のインスタンスを初期化します
        /// </summary>
        /// <param name="installer">担当するインストーラ</param>
        /// <param name="remainingInstallCount">残りのインストール数</param>
        public ImtArchiveEntryInstallProgressInfo(ImtArchiveEntryInstaller installer, int remainingInstallCount)
        {
            // 初期化をする
            Installer = installer;
            RemainingInstallCount = remainingInstallCount;
        }
    }
}