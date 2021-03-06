﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using Mozilla.Glean;
using System;
using System.IO;
using static Mozilla.Glean.Glean;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string gleanDataDir = Directory.GetCurrentDirectory() + "\\glean_data";
            Console.WriteLine("Adding Glean data to {0}", gleanDataDir);

            GleanInstance.Initialize(
                applicationId: "org.mozilla.glean.csharp.sample",
                applicationVersion: "1.0",
                uploadEnabled: true,
                configuration: new Configuration(maxEvents: 37),
                dataDir: gleanDataDir
                );
        }
    }
}
