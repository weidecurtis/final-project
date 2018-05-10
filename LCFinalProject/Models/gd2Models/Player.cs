using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models.gd2Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Player
    {
        private PlayerVs_LHB vs_LHBField;

        private PlayerVs_RHB vs_RHBField;

        private PlayerVs_B vs_BField;

        private PlayerVs_B5 vs_B5Field;

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

        private int idField;

        private string posField;

        private string current_positionField;

        private string typeField;

        private string first_nameField;

        private string last_nameField;

        /// <remarks/>
        public PlayerVs_LHB vs_LHB
        {
            get
            {
                return this.vs_LHBField;
            }
            set
            {
                this.vs_LHBField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_RHB vs_RHB
        {
            get
            {
                return this.vs_RHBField;
            }
            set
            {
                this.vs_RHBField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_B vs_B
        {
            get
            {
                return this.vs_BField;
            }
            set
            {
                this.vs_BField = value;
            }
        }

        /// <remarks/>
        public PlayerVs_B5 vs_B5
        {
            get
            {
                return this.vs_B5Field;
            }
            set
            {
                this.vs_B5Field = value;
            }
        }

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
        public int id
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
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PlayerSeason
        {

            private decimal avgField;

            private ushort abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

            private decimal opsField;

            private int wField;

            private int lField;

            private int svField;

            private decimal ipField;

            private string eraField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int w
            {
                get
                {
                    return this.wField;
                }
                set
                {
                    this.wField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int l
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int sv
            {
                get
                {
                    return this.svField;
                }
                set
                {
                    this.svField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int sbField;

            private int csField;

            private int hrField;

            private ushort rbiField;

            private decimal opsField;

            private int wField;

            private int lField;

            private int svField;

            private decimal ipField;

            private string eraField;


            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int w
            {
                get
                {
                    return this.wField;
                }
                set
                {
                    this.wField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int l
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int sv
            {
                get
                {
                    return this.svField;
                }
                set
                {
                    this.svField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
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
            public int sb
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
            public int cs
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
            public int hr
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
            private decimal ipField;

            private string eraField;

            private string desField;

            private decimal avgField;

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

            private decimal opsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
                }
            }

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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private decimal ipField;

            private string eraField;

            private string desField;

            private decimal avgField;

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

            private decimal opsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }


            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
                }
            }

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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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
            private decimal ipField;


            private string eraField;

            private decimal avgField;

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

            private decimal opsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }


            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

            private decimal opsField;

            private decimal ipField;

            private string eraField;


            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }



            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

            private decimal opsField;

            private decimal ipField;

            private string eraField;




            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PlayerVs_LHB
        {

            private decimal avgField;

            private int abField;

            private int hField;

            private int rbiField;

            private int hrField;

            private int bbField;

            private int soField;

            private decimal ipField;

            private string eraField;

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
            public int ab
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
            public int h
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
            public int rbi
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
            public int hr
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
            public int bb
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
            public int so
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
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PlayerVs_RHB
        {

            private decimal avgField;

            private int abField;

            private int hField;

            private int rbiField;

            private int hrField;

            private int bbField;

            private int soField;

            private decimal ipField;

            private string eraField;

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
            public int ab
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
            public int h
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
            public int rbi
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
            public int hr
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
            public int bb
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
            public int so
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
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PlayerVs_B
        {

            private string desField;

            private decimal avgField;

            private int abField;

            private int hField;

            private int rbiField;

            private int hrField;

            private int bbField;

            private int soField;

            private decimal ipField;

            private string eraField;

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
            public int ab
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
            public int h
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
            public int rbi
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
            public int hr
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
            public int bb
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
            public int so
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
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PlayerVs_B5
        {

            private string desField;

            private decimal avgField;

            private int abField;

            private int hField;

            private int rbiField;

            private int hrField;

            private int bbField;

            private int soField;

            private decimal ipField;

            private string eraField;

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
            public int ab
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
            public int h
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
            public int rbi
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
            public int hr
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
            public int bb
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
            public int so
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
            public decimal ip
            {
                get
                {
                    return this.ipField;
                }
                set
                {
                    this.ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string era
            {
                get
                {
                    return this.eraField;
                }
                set
                {
                    this.eraField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PlayerPitch
        {

            private string outField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @out
            {
                get
                {
                    return this.outField;
                }
                set
                {
                    this.outField = value;
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

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int abField;

            private int hField;

            private int bbField;

            private int soField;

            private int rField;

            private int sbField;

            private int csField;

            private int hrField;

            private int rbiField;

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
            public int ab
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
            public int h
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
            public int bb
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
            public int so
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
            public int r
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
            public int sb
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
            public int cs
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
            public int hr
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
            public int rbi
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

            private int inningField;

            private string eventField;

            private string event_esField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int inning
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
}

