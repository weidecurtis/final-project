using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LCFinalProject.Models.gd2Models
{
    [Serializable, XmlRoot("games")]
    public class GameDirectory
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class game
        {

            private gameWinning_pitcher winning_pitcherField;

            private gameLosing_pitcher losing_pitcherField;

            private string idField;

            private string venueField;

            private uint game_pkField;

            private string timeField;

            private string time_dateField;

            private string time_date_aw_lgField;

            private string time_date_hm_lgField;

            private string time_zoneField;

            private string ampmField;

            private string away_timeField;

            private string away_time_zoneField;

            private string away_ampmField;

            private string home_timeField;

            private string home_time_zoneField;

            private string home_ampmField;

            private string game_typeField;

            private string tiebreaker_swField;

            private string original_dateField;

            private sbyte time_zone_aw_lgField;

            private sbyte time_zone_hm_lgField;

            private string time_aw_lgField;

            private string aw_lg_ampmField;

            private string tz_aw_lg_genField;

            private string time_hm_lgField;

            private string hm_lg_ampmField;

            private string tz_hm_lg_genField;

            private ushort venue_idField;

            private byte scheduled_inningsField;

            private string away_name_abbrevField;

            private string home_name_abbrevField;

            private string away_codeField;

            private string away_file_codeField;

            private byte away_team_idField;

            private string away_team_cityField;

            private string away_team_nameField;

            private string away_divisionField;

            private byte away_league_idField;

            private string away_sport_codeField;

            private string home_codeField;

            private string home_file_codeField;

            private byte home_team_idField;

            private string home_team_cityField;

            private string home_team_nameField;

            private string home_divisionField;

            private byte home_league_idField;

            private string home_sport_codeField;

            private string dayField;

            private string gameday_swField;

            private string double_header_swField;

            private byte game_nbrField;

            private string tbd_flagField;

            private string away_games_backField;

            private string home_games_backField;

            private string home_games_back_wildcardField;

            private string venue_w_chan_locField;

            private string locationField;

            private string gameday_linkField;

            private byte away_winField;

            private byte away_lossField;

            private byte home_winField;

            private byte home_lossField;

            private string game_data_directoryField;

            private byte inning_break_lengthField;

            private string leagueField;

            private string calendar_event_idField;

            private string media_stateField;

            private string top_inningField;

            private string statusField;

            private string indField;

            private byte inningField;

            private byte outsField;

            private byte away_team_runsField;

            private byte home_team_runsField;

            private byte away_team_hitsField;

            private byte home_team_hitsField;

            private byte away_team_errorsField;

            private byte home_team_errorsField;

            private string mlbtv_linkField;

            private string wrapup_linkField;

            private string home_audio_linkField;

            private string away_audio_linkField;

            private string home_preview_linkField;

            private string away_preview_linkField;

            private string preview_linkField;

            private string tv_stationField;

            private string away_games_back_wildcardField;

            /// <remarks/>
            public gameWinning_pitcher winning_pitcher
            {
                get
                {
                    return this.winning_pitcherField;
                }
                set
                {
                    this.winning_pitcherField = value;
                }
            }

            /// <remarks/>
            public gameLosing_pitcher losing_pitcher
            {
                get
                {
                    return this.losing_pitcherField;
                }
                set
                {
                    this.losing_pitcherField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
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
            public string venue
            {
                get
                {
                    return this.venueField;
                }
                set
                {
                    this.venueField = value;
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
            public string time
            {
                get
                {
                    return this.timeField;
                }
                set
                {
                    this.timeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time_date
            {
                get
                {
                    return this.time_dateField;
                }
                set
                {
                    this.time_dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time_date_aw_lg
            {
                get
                {
                    return this.time_date_aw_lgField;
                }
                set
                {
                    this.time_date_aw_lgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time_date_hm_lg
            {
                get
                {
                    return this.time_date_hm_lgField;
                }
                set
                {
                    this.time_date_hm_lgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time_zone
            {
                get
                {
                    return this.time_zoneField;
                }
                set
                {
                    this.time_zoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ampm
            {
                get
                {
                    return this.ampmField;
                }
                set
                {
                    this.ampmField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_time
            {
                get
                {
                    return this.away_timeField;
                }
                set
                {
                    this.away_timeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_time_zone
            {
                get
                {
                    return this.away_time_zoneField;
                }
                set
                {
                    this.away_time_zoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_ampm
            {
                get
                {
                    return this.away_ampmField;
                }
                set
                {
                    this.away_ampmField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_time
            {
                get
                {
                    return this.home_timeField;
                }
                set
                {
                    this.home_timeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_time_zone
            {
                get
                {
                    return this.home_time_zoneField;
                }
                set
                {
                    this.home_time_zoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_ampm
            {
                get
                {
                    return this.home_ampmField;
                }
                set
                {
                    this.home_ampmField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string game_type
            {
                get
                {
                    return this.game_typeField;
                }
                set
                {
                    this.game_typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tiebreaker_sw
            {
                get
                {
                    return this.tiebreaker_swField;
                }
                set
                {
                    this.tiebreaker_swField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string original_date
            {
                get
                {
                    return this.original_dateField;
                }
                set
                {
                    this.original_dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte time_zone_aw_lg
            {
                get
                {
                    return this.time_zone_aw_lgField;
                }
                set
                {
                    this.time_zone_aw_lgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte time_zone_hm_lg
            {
                get
                {
                    return this.time_zone_hm_lgField;
                }
                set
                {
                    this.time_zone_hm_lgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time_aw_lg
            {
                get
                {
                    return this.time_aw_lgField;
                }
                set
                {
                    this.time_aw_lgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string aw_lg_ampm
            {
                get
                {
                    return this.aw_lg_ampmField;
                }
                set
                {
                    this.aw_lg_ampmField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tz_aw_lg_gen
            {
                get
                {
                    return this.tz_aw_lg_genField;
                }
                set
                {
                    this.tz_aw_lg_genField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time_hm_lg
            {
                get
                {
                    return this.time_hm_lgField;
                }
                set
                {
                    this.time_hm_lgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string hm_lg_ampm
            {
                get
                {
                    return this.hm_lg_ampmField;
                }
                set
                {
                    this.hm_lg_ampmField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tz_hm_lg_gen
            {
                get
                {
                    return this.tz_hm_lg_genField;
                }
                set
                {
                    this.tz_hm_lg_genField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort venue_id
            {
                get
                {
                    return this.venue_idField;
                }
                set
                {
                    this.venue_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte scheduled_innings
            {
                get
                {
                    return this.scheduled_inningsField;
                }
                set
                {
                    this.scheduled_inningsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_name_abbrev
            {
                get
                {
                    return this.away_name_abbrevField;
                }
                set
                {
                    this.away_name_abbrevField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_name_abbrev
            {
                get
                {
                    return this.home_name_abbrevField;
                }
                set
                {
                    this.home_name_abbrevField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_code
            {
                get
                {
                    return this.away_codeField;
                }
                set
                {
                    this.away_codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_file_code
            {
                get
                {
                    return this.away_file_codeField;
                }
                set
                {
                    this.away_file_codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_team_id
            {
                get
                {
                    return this.away_team_idField;
                }
                set
                {
                    this.away_team_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_team_city
            {
                get
                {
                    return this.away_team_cityField;
                }
                set
                {
                    this.away_team_cityField = value;
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
            public string away_division
            {
                get
                {
                    return this.away_divisionField;
                }
                set
                {
                    this.away_divisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_league_id
            {
                get
                {
                    return this.away_league_idField;
                }
                set
                {
                    this.away_league_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_sport_code
            {
                get
                {
                    return this.away_sport_codeField;
                }
                set
                {
                    this.away_sport_codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_code
            {
                get
                {
                    return this.home_codeField;
                }
                set
                {
                    this.home_codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_file_code
            {
                get
                {
                    return this.home_file_codeField;
                }
                set
                {
                    this.home_file_codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_team_id
            {
                get
                {
                    return this.home_team_idField;
                }
                set
                {
                    this.home_team_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_team_city
            {
                get
                {
                    return this.home_team_cityField;
                }
                set
                {
                    this.home_team_cityField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_division
            {
                get
                {
                    return this.home_divisionField;
                }
                set
                {
                    this.home_divisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_league_id
            {
                get
                {
                    return this.home_league_idField;
                }
                set
                {
                    this.home_league_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_sport_code
            {
                get
                {
                    return this.home_sport_codeField;
                }
                set
                {
                    this.home_sport_codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string gameday_sw
            {
                get
                {
                    return this.gameday_swField;
                }
                set
                {
                    this.gameday_swField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string double_header_sw
            {
                get
                {
                    return this.double_header_swField;
                }
                set
                {
                    this.double_header_swField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte game_nbr
            {
                get
                {
                    return this.game_nbrField;
                }
                set
                {
                    this.game_nbrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tbd_flag
            {
                get
                {
                    return this.tbd_flagField;
                }
                set
                {
                    this.tbd_flagField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_games_back
            {
                get
                {
                    return this.away_games_backField;
                }
                set
                {
                    this.away_games_backField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_games_back
            {
                get
                {
                    return this.home_games_backField;
                }
                set
                {
                    this.home_games_backField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_games_back_wildcard
            {
                get
                {
                    return this.home_games_back_wildcardField;
                }
                set
                {
                    this.home_games_back_wildcardField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string venue_w_chan_loc
            {
                get
                {
                    return this.venue_w_chan_locField;
                }
                set
                {
                    this.venue_w_chan_locField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string gameday_link
            {
                get
                {
                    return this.gameday_linkField;
                }
                set
                {
                    this.gameday_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_win
            {
                get
                {
                    return this.away_winField;
                }
                set
                {
                    this.away_winField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_loss
            {
                get
                {
                    return this.away_lossField;
                }
                set
                {
                    this.away_lossField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_win
            {
                get
                {
                    return this.home_winField;
                }
                set
                {
                    this.home_winField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_loss
            {
                get
                {
                    return this.home_lossField;
                }
                set
                {
                    this.home_lossField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string game_data_directory
            {
                get
                {
                    return this.game_data_directoryField;
                }
                set
                {
                    this.game_data_directoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte inning_break_length
            {
                get
                {
                    return this.inning_break_lengthField;
                }
                set
                {
                    this.inning_break_lengthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string league
            {
                get
                {
                    return this.leagueField;
                }
                set
                {
                    this.leagueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string calendar_event_id
            {
                get
                {
                    return this.calendar_event_idField;
                }
                set
                {
                    this.calendar_event_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string media_state
            {
                get
                {
                    return this.media_stateField;
                }
                set
                {
                    this.media_stateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string top_inning
            {
                get
                {
                    return this.top_inningField;
                }
                set
                {
                    this.top_inningField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ind
            {
                get
                {
                    return this.indField;
                }
                set
                {
                    this.indField = value;
                }
            }

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
            public byte outs
            {
                get
                {
                    return this.outsField;
                }
                set
                {
                    this.outsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_team_runs
            {
                get
                {
                    return this.away_team_runsField;
                }
                set
                {
                    this.away_team_runsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_team_runs
            {
                get
                {
                    return this.home_team_runsField;
                }
                set
                {
                    this.home_team_runsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_team_hits
            {
                get
                {
                    return this.away_team_hitsField;
                }
                set
                {
                    this.away_team_hitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_team_hits
            {
                get
                {
                    return this.home_team_hitsField;
                }
                set
                {
                    this.home_team_hitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte away_team_errors
            {
                get
                {
                    return this.away_team_errorsField;
                }
                set
                {
                    this.away_team_errorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte home_team_errors
            {
                get
                {
                    return this.home_team_errorsField;
                }
                set
                {
                    this.home_team_errorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string mlbtv_link
            {
                get
                {
                    return this.mlbtv_linkField;
                }
                set
                {
                    this.mlbtv_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string wrapup_link
            {
                get
                {
                    return this.wrapup_linkField;
                }
                set
                {
                    this.wrapup_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_audio_link
            {
                get
                {
                    return this.home_audio_linkField;
                }
                set
                {
                    this.home_audio_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_audio_link
            {
                get
                {
                    return this.away_audio_linkField;
                }
                set
                {
                    this.away_audio_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string home_preview_link
            {
                get
                {
                    return this.home_preview_linkField;
                }
                set
                {
                    this.home_preview_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_preview_link
            {
                get
                {
                    return this.away_preview_linkField;
                }
                set
                {
                    this.away_preview_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string preview_link
            {
                get
                {
                    return this.preview_linkField;
                }
                set
                {
                    this.preview_linkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tv_station
            {
                get
                {
                    return this.tv_stationField;
                }
                set
                {
                    this.tv_stationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string away_games_back_wildcard
            {
                get
                {
                    return this.away_games_back_wildcardField;
                }
                set
                {
                    this.away_games_back_wildcardField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class gameWinning_pitcher
        {

            private string first_nameField;

            private uint idField;

            private string last_nameField;

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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class gameLosing_pitcher
        {

            private string first_nameField;

            private uint idField;

            private string last_nameField;

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
        }


    }
}
