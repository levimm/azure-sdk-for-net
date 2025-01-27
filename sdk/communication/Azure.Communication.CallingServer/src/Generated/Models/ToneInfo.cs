// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> Gets or sets the tone info. </summary>
    public partial class ToneInfo
    {
        /// <summary> Initializes a new instance of ToneInfo. </summary>
        public ToneInfo()
        {
        }

        /// <summary> Initializes a new instance of ToneInfo. </summary>
        /// <param name="sequenceId">
        /// Gets or sets the sequence id. This id can be used to determine if the same tone
        /// 
        /// was played multiple times or if any tones were missed.
        /// </param>
        /// <param name="tone"> Gets or sets the tone detected. </param>
        internal ToneInfo(int? sequenceId, ToneValue? tone)
        {
            SequenceId = sequenceId;
            Tone = tone;
        }

        /// <summary>
        /// Gets or sets the sequence id. This id can be used to determine if the same tone
        /// 
        /// was played multiple times or if any tones were missed.
        /// </summary>
        public int? SequenceId { get; set; }
        /// <summary> Gets or sets the tone detected. </summary>
        public ToneValue? Tone { get; set; }
    }
}
