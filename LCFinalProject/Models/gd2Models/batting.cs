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
        public partial class batting
        {

            private int abField;

            private int rField;

            private int hField;

            private int hrField;

            private int rbiField;

            private int sbField;

            private decimal avgField;

            private int singleField;

            private int doubleField;

            private int tripleField;

            private int bbField;

            private int csField;

            private int soField;

            private int errField;

            private int hbpField;

            private string last_at_batField;

            private int s_abField;

            private int s_hrField;

            private int s_rbiField;

            private int s_sbField;

            private int s_hField;

            private int s_rField;

            private int s_singleField;

            private int s_doubleField;

            private int s_tripleField;

            private int s_bbField;

            private int s_csField;

            private int s_soField;

            private int s_errField;

            private int s_hbpField;

            private string game_idField;

            private uint game_pkField;

            private int update_ABField;

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
            public int single
            {
                get
                {
                    return this.singleField;
                }
                set
                {
                    this.singleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int @double
            {
                get
                {
                    return this.doubleField;
                }
                set
                {
                    this.doubleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int triple
            {
                get
                {
                    return this.tripleField;
                }
                set
                {
                    this.tripleField = value;
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
            public int err
            {
                get
                {
                    return this.errField;
                }
                set
                {
                    this.errField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int hbp
            {
                get
                {
                    return this.hbpField;
                }
                set
                {
                    this.hbpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string last_at_bat
            {
                get
                {
                    return this.last_at_batField;
                }
                set
                {
                    this.last_at_batField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_ab
            {
                get
                {
                    return this.s_abField;
                }
                set
                {
                    this.s_abField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_hr
            {
                get
                {
                    return this.s_hrField;
                }
                set
                {
                    this.s_hrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_rbi
            {
                get
                {
                    return this.s_rbiField;
                }
                set
                {
                    this.s_rbiField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_sb
            {
                get
                {
                    return this.s_sbField;
                }
                set
                {
                    this.s_sbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_h
            {
                get
                {
                    return this.s_hField;
                }
                set
                {
                    this.s_hField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_r
            {
                get
                {
                    return this.s_rField;
                }
                set
                {
                    this.s_rField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_single
            {
                get
                {
                    return this.s_singleField;
                }
                set
                {
                    this.s_singleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_double
            {
                get
                {
                    return this.s_doubleField;
                }
                set
                {
                    this.s_doubleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_triple
            {
                get
                {
                    return this.s_tripleField;
                }
                set
                {
                    this.s_tripleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_bb
            {
                get
                {
                    return this.s_bbField;
                }
                set
                {
                    this.s_bbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_cs
            {
                get
                {
                    return this.s_csField;
                }
                set
                {
                    this.s_csField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_so
            {
                get
                {
                    return this.s_soField;
                }
                set
                {
                    this.s_soField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_err
            {
                get
                {
                    return this.s_errField;
                }
                set
                {
                    this.s_errField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int s_hbp
            {
                get
                {
                    return this.s_hbpField;
                }
                set
                {
                    this.s_hbpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string game_id
            {
                get
                {
                    return this.game_idField;
                }
                set
                {
                    this.game_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint game_pk
            {
                get
                {
                    return this.game_pkField;
                }
                set
                {
                    this.game_pkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int update_AB
            {
                get
                {
                    return this.update_ABField;
                }
                set
                {
                    this.update_ABField = value;
                }
            }
        }


}
