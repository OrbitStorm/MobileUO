﻿#region license
// Copyright (C) 2020 ClassicUO Development Community on Github
// 
// This project is an alternative client for the game Ultima Online.
// The goal of this is to develop a lightweight client considering
// new technologies.
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.
#endregion

namespace ClassicUO.IO.Audio.MP3Sharp.Decoding.Decoders.LayerIII
{
    internal class SBI
    {
        public int[] l;
        public int[] s;

        public SBI()
        {
            l = new int[23];
            s = new int[14];
        }

        public SBI(int[] thel, int[] thes)
        {
            l = thel;
            s = thes;
        }
    }
}