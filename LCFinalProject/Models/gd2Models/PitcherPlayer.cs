using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models.gd2Models
{
    public class PitcherPlayer
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class pitching
        {

            private decimal ipField;

            private byte hField;

            private byte erField;

            private byte rField;

            private byte bbField;

            private byte kField;

            private decimal whipField;

            private byte svField;

            private byte hraField;

            private byte npField;

            private byte sField;

            private byte hbpField;

            private byte wField;

            private byte lField;

            private decimal eraField;

            private decimal s_ipField;

            private byte s_hField;

            private byte s_erField;

            private byte s_rField;

            private byte s_bbField;

            private byte s_kField;

            private byte s_svField;

            private byte s_hbpField;

            private byte s_hraField;

            private string game_idField;

            private uint game_pkField;

            private byte update_ABField;

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
            public byte er
            {
                get
                {
                    return this.erField;
                }
                set
                {
                    this.erField = value;
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
            public byte k
            {
                get
                {
                    return this.kField;
                }
                set
                {
                    this.kField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal whip
            {
                get
                {
                    return this.whipField;
                }
                set
                {
                    this.whipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sv
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
            public byte hra
            {
                get
                {
                    return this.hraField;
                }
                set
                {
                    this.hraField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte np
            {
                get
                {
                    return this.npField;
                }
                set
                {
                    this.npField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte s
            {
                get
                {
                    return this.sField;
                }
                set
                {
                    this.sField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte hbp
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
            public byte w
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
            public byte l
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
            public decimal era
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
            public decimal s_ip
            {
                get
                {
                    return this.s_ipField;
                }
                set
                {
                    this.s_ipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte s_h
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
            public byte s_er
            {
                get
                {
                    return this.s_erField;
                }
                set
                {
                    this.s_erField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte s_r
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
            public byte s_bb
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
            public byte s_k
            {
                get
                {
                    return this.s_kField;
                }
                set
                {
                    this.s_kField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte s_sv
            {
                get
                {
                    return this.s_svField;
                }
                set
                {
                    this.s_svField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte s_hbp
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
            public byte s_hra
            {
                get
                {
                    return this.s_hraField;
                }
                set
                {
                    this.s_hraField = value;
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
            public byte update_AB
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
}
