using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models.gd2Models
{
    /*
    [Serializable()]
    public class Player
    {
        [System.Xml.Serialization.XmlElement("first_name")]
        public string first_name { get; set; }

        [System.Xml.Serialization.XmlElement("last_name")]
        public string last_name { get; set; }

    }*/


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Player
    {

        private PlayerSeason seasonField;

        private PlayerCareer careerField;

        private PlayerMonth monthField;

        private PlayerTeam teamField;

        private PlayerEmpty emptyField;

        private PlayerMen_On men_OnField;

        private PlayerRISP rISPField;

        private PlayerLoaded loadedField;

        private PlayerVs_LHP vs_LHPField;

        private PlayerVs_RHP vs_RHPField;

        private PlayerVs_P vs_PField;

        private PlayerVs_P5 vs_P5Field;

        private PlayerPitch pitchField;

        private PlayerPitch1[] facedField;

        private PlayerAB[] atbatsField;

        private string teamField1;

        private uint idField;

        private string posField;

        private string current_positionField;

        private string typeField;

        private string first_nameField;

        private string last_nameField;

        private byte jersey_numberField;

        private string heightField;

        private byte weightField;

        private string batsField;

        private string throwsField;

        private string dobField;

        /// <remarks/>
        public PlayerSeason season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public PlayerCareer career
        {
            get
            {
                return this.careerField;
            }
            set
            {
                this.careerField = value;
            }
        }

        /// <remarks/>
        public PlayerMonth month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        public PlayerTeam Team
        {
            get
            {
                return this.teamField;
            }
            set
            {
                this.teamField = value;
            }
        }

        /// <remarks/>
        public PlayerEmpty Empty
        {
            get
            {
                return this.emptyField;
            }
            set
            {
                this.emptyField = value;
            }
        }

        /// <remarks/>
        public PlayerMen_On Men_On
        {
            get
            {
                return this.men_OnField;
            }
            set
            {
                this.men_OnField = value;
            }
        }

        /// <remarks/>
        public PlayerRISP RISP
        {
            get
            {
                return this.rISPField;
            }
            set
            {
                this.rISPField = value;
            }
        }

        /// <remarks/>
        public PlayerLoaded Loaded
        {
            get
            {
                return this.loadedField;
            }
            set
            {
                this.loadedField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_LHP vs_LHP
        {
            get
            {
                return this.vs_LHPField;
            }
            set
            {
                this.vs_LHPField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_RHP vs_RHP
        {
            get
            {
                return this.vs_RHPField;
            }
            set
            {
                this.vs_RHPField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_P vs_P
        {
            get
            {
                return this.vs_PField;
            }
            set
            {
                this.vs_PField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_P5 vs_P5
        {
            get
            {
                return this.vs_P5Field;
            }
            set
            {
                this.vs_P5Field = value;
            }
        }

        /// <remarks/>
        public PlayerPitch Pitch
        {
            get
            {
                return this.pitchField;
            }
            set
            {
                this.pitchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("pitch", IsNullable = false)]
        public PlayerPitch1[] faced
        {
            get
            {
                return this.facedField;
            }
            set
            {
                this.facedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ab", IsNullable = false)]
        public PlayerAB[] atbats
        {
            get
            {
                return this.atbatsField;
            }
            set
            {
                this.atbatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string team
        {
            get
            {
                return this.teamField1;
            }
            set
            {
                this.teamField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string current_position
        {
            get
            {
                return this.current_positionField;
            }
            set
            {
                this.current_positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string first_name
        {
            get
            {
                return this.first_nameField;
            }
            set
            {
                this.first_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string last_name
        {
            get
            {
                return this.last_nameField;
            }
            set
            {
                this.last_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte jersey_number
        {
            get
            {
                return this.jersey_numberField;
            }
            set
            {
                this.jersey_numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bats
        {
            get
            {
                return this.batsField;
            }
            set
            {
                this.batsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string throws
        {
            get
            {
                return this.throwsField;
            }
            set
            {
                this.throwsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dob
        {
            get
            {
                return this.dobField;
            }
            set
            {
                this.dobField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerSeason
    {

        private decimal avgField;

        private ushort abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerCareer
    {

        private decimal avgField;

        private ushort abField;

        private ushort hField;

        private ushort bbField;

        private ushort soField;

        private ushort rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private ushort rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerMonth
    {

        private string desField;

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string des
        {
            get
            {
                return this.desField;
            }
            set
            {
                this.desField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerTeam
    {

        private string desField;

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string des
        {
            get
            {
                return this.desField;
            }
            set
            {
                this.desField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerEmpty
    {

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerMen_On
    {

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerRISP
    {

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerLoaded
    {

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerVs_LHP
    {

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerVs_RHP
    {

        private decimal avgField;

        private ushort abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerVs_P
    {

        private string desField;

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string des
        {
            get
            {
                return this.desField;
            }
            set
            {
                this.desField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerVs_P5
    {

        private string desField;

        private decimal avgField;

        private byte abField;

        private byte hField;

        private byte bbField;

        private byte soField;

        private byte rField;

        private byte sbField;

        private byte csField;

        private byte hrField;

        private byte rbiField;

        private decimal opsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string des
        {
            get
            {
                return this.desField;
            }
            set
            {
                this.desField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal avg
        {
            get
            {
                return this.avgField;
            }
            set
            {
                this.avgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return this.abField;
            }
            set
            {
                this.abField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return this.bbField;
            }
            set
            {
                this.bbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return this.soField;
            }
            set
            {
                this.soField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return this.hrField;
            }
            set
            {
                this.hrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return this.rbiField;
            }
            set
            {
                this.rbiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ops
        {
            get
            {
                return this.opsField;
            }
            set
            {
                this.opsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerPitch
    {

        private string lovesField;

        private string hatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string loves
        {
            get
            {
                return this.lovesField;
            }
            set
            {
                this.lovesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hates
        {
            get
            {
                return this.hatesField;
            }
            set
            {
                this.hatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerPitch1
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PlayerAB
    {

        private byte inningField;

        private string eventField;

        private string event_esField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inning
        {
            get
            {
                return this.inningField;
            }
            set
            {
                this.inningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string event_es
        {
            get
            {
                return this.event_esField;
            }
            set
            {
                this.event_esField = value;
            }
        }
    }


}
