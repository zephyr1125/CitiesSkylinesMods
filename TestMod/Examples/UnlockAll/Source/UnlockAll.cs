using System;
using System.IO;
using System.Reflection;
using ICities;
using UnityEngine;

namespace UnlockAllMod {

    public class UnlockAll : IUserMod {

        public string Name {
            get { return "Unlock All"; }
        }

        public string Description {
            get { return "Progression milestones are always unlocked"; }
        }

    }

    public class UnlockAllMilestones : MilestonesExtensionBase {

        public override void OnRefreshMilestones() {
            milestonesManager.UnlockMilestone("Basic Road Created");
        }

        public override int OnGetPopulationTarget(int originalTarget, int scaledTarget) {
            return 0;
        }

    }

}
