﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Platform;
using osu.Framework.Testing;
using osu.Game;
using osu.Game.Screens.Backgrounds;

namespace osu.Desktop.VisualTests
{
    internal class VisualTestGame : OsuGameBase
    {
        protected override void LoadComplete()
        {
            base.LoadComplete();

            new BackgroundScreenDefault { Depth = 10 }.LoadAsync(this, AddInternal);

            // Have to construct this here, rather than in the constructor, because
            // we depend on some dependencies to be loaded within OsuGameBase.load().
            Add(new TestBrowser());
        }

        public override void SetHost(GameHost host)
        {
            base.SetHost(host);
            host.Window.CursorState = CursorState.Hidden;
        }
    }
}
