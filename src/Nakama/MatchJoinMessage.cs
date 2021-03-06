/**
 * Copyright 2018 The Nakama Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
    /// <summary>
    /// A join message for a match on the server.
    /// </summary>
    internal class MatchJoinMessage
    {
        [DataMember(Name="match_id")]
        public string MatchId { get; set; }

        [DataMember(Name="token")]
        public string Token { get; set; }
        
        [DataMember(Name="metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        public override string ToString()
        {
            return $"MatchJoinMessage(MatchId='{MatchId}', Token='{Token}, Metadata='{Metadata}')";
        }
    }
}
