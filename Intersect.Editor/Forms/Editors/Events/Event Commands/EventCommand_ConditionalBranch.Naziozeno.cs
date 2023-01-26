using System;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    public partial class EventCommandConditionalBranch
    {
        private void ExtraLoad()
        {
            nudMaxValue.Minimum = long.MinValue;
            nudMaxValue.Maximum = long.MaxValue;
        }

        private void cmbNumericComparitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumericVariableElements();
        }
    }
}
