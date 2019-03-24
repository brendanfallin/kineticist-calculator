using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KineticistDamageCalculator
{
    class InfusionObject
    {
        #region properties
        private int effectiveSpellLevel;
        private string element;
        private bool formInfusion;
        private bool physicalBlast;
        private List<string> associatedElements;
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
        public string Element
        {
            get => element;
            protected set => element = value;
        }
        public bool FormInfusion
        {
            get => formInfusion;
            protected set => formInfusion = value;
        }
        public bool PhysicalBlast
        {
            get => physicalBlast;
            protected set => physicalBlast = value;
        }
        public List<string> AssociatedElements
        {
            get => associatedElements;
            protected set => associatedElements = value;
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
        internal InfusionObject (int effectiveSpellLevel, string element, bool formInfusion, bool physicalBlast, 
            List<string> associatedElements, bool compositeBlast, bool allowsSavingThrow, string associatedAbilityScore, 
            double onPassSavingThrow, double onFailSavingThrow)
        {
            this.EffectiveSpellLevel = effectiveSpellLevel;
            this.Element = element;
            this.FormInfusion = formInfusion;
            this.PhysicalBlast = physicalBlast;
            this.associatedElements = associatedElements;
            this.CompositeBlast = compositeBlast;
            this.AllowsSavingThrow = allowsSavingThrow;
            this.AssociatedAbilityScore = associatedAbilityScore;
            this.OnPassSavingThrow = onPassSavingThrow;
            this.OnFailSavingThrow = onFailSavingThrow;
        }
        #endregion constructor
    }
}
