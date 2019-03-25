using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastEngine
{
    class InfusionObject : BasicBlastObject
    {
        #region properties

        private int effectiveSpellLevel;
        private bool formInfusion;
        private List<BasicBlastObject> associatedBlasts;
        private bool compositeBlast;
        private bool allowsSavingThrow;
        private string associatedAbilityScore;
        private double onPassSavingThrow;
        private double onFailSavingThrow;

        #endregion properties

        #region get/set

        public int EffectiveSpellLevel
        {
            get => effectiveSpellLevel;
            protected set => effectiveSpellLevel = value;
        }
        public bool FormInfusion
        {
            get => formInfusion;
            protected set => formInfusion = value;
        }
        public List<BasicBlastObject> AssociatedBlasts
        {
            get => associatedBlasts;
            protected set => associatedBlasts = value;
        }
        public bool CompositeBlast
        {
            get => compositeBlast;
            protected set => compositeBlast = value;
        }
        public bool AllowsSavingThrow
        {
            get => allowsSavingThrow;
            protected set => allowsSavingThrow = value;
        }
        public string AssociatedAbilityScore
        {
            get => associatedAbilityScore;
            protected set => associatedAbilityScore = value;
        }
        public double OnPassSavingThrow
        {
            get => onPassSavingThrow;
            protected set => onPassSavingThrow = value;
        }
        public double OnFailSavingThrow
        {
            get => onFailSavingThrow;
            protected set => onFailSavingThrow = value;
        }

        #endregion get/set

        #region constructor
        internal InfusionObject (string name, int effectiveSpellLevel, string element, bool formInfusion, bool physicalBlast, 
            List<BasicBlastObject> associatedBlasts, bool compositeBlast, bool allowsSavingThrow, string associatedAbilityScore, 
            double onPassSavingThrow, double onFailSavingThrow) : base(name, element, physicalBlast)
        {
            this.Name = name;
            this.EffectiveSpellLevel = effectiveSpellLevel;
            this.Element = element;
            this.FormInfusion = formInfusion;
            this.PhysicalBlast = physicalBlast;
            this.associatedBlasts = associatedBlasts;
            this.CompositeBlast = compositeBlast;
            this.AllowsSavingThrow = allowsSavingThrow;
            this.AssociatedAbilityScore = associatedAbilityScore;
            this.OnPassSavingThrow = onPassSavingThrow;
            this.OnFailSavingThrow = onFailSavingThrow;
        }
        #endregion constructor
    }
}
