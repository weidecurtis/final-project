using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Xml;

namespace LCFinalProject.Models.gd2Models
{

    public class GameData
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
        public partial class games
        {

            private gamesGame gameField;

            private uint dateField;

            private string last_modifiedField;

            /// <remarks/>
            public gamesGame game
            {
                get
                {
                    return this.gameField;
                }
                set
                {
                    this.gameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string last_modified
            {
                get
                {
                    return this.last_modifiedField;
                }
                set
                {
                    this.last_modifiedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class gamesGame
        {

            private gamesGameHome_probable_pitcher home_probable_pitcherField;

            private gamesGameAway_probable_pitcher away_probable_pitcherField;

            private gamesGameGame_media game_mediaField;

            private string away_team_nameField;

            private string home_team_nameField;

            /// <remarks/>
            public gamesGameHome_probable_pitcher home_probable_pitcher
            {
                get
                {
                    return this.home_probable_pitcherField;
                }
                set
                {
                    this.home_probable_pitcherField = value;
                }
            }

            /// <remarks/>
            public gamesGameAway_probable_pitcher away_probable_pitcher
            {
                get
                {
                    return this.away_probable_pitcherField;
                }
                set
                {
                    this.away_probable_pitcherField = value;
                }
            }

            
         
            /// <remarks/>
            public gamesGameGame_media game_media
            {
                get
                {
                    return this.game_mediaField;
                }
                set
                {
                    this.game_mediaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_team_name
            {
                get
                {
                    return this.away_team_nameField;
                }
                set
                {
                    this.away_team_nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_team_name
            {
                get
                {
                    return this.home_team_nameField;
                }
                set
                {
                    this.home_team_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class gamesGameHome_probable_pitcher
        {

            private string first_nameField;

            private uint idField;

            private string last_nameField;

            private string throwinghandField;

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
            public string throwinghand
            {
                get
                {
                    return this.throwinghandField;
                }
                set
                {
                    this.throwinghandField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class gamesGameAway_probable_pitcher
        {

            private string first_nameField;

            private uint idField;

            private string last_nameField;

            private string throwinghandField;

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
            public string throwinghand
            {
                get
                {
                    return this.throwinghandField;
                }
                set
                {
                    this.throwinghandField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class gamesGameGame_media
        {

            private gamesGameGame_mediaMedia mediaField;

            /// <remarks/>
            public gamesGameGame_mediaMedia media
            {
                get
                {
                    return this.mediaField;
                }
                set
                {
                    this.mediaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(IsNullable = true)]
        public partial class gamesGameGame_mediaMedia
        {

            private string titleField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }
        }


    }
}