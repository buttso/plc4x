//
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
//

namespace org.apache.plc4net.drivers.knxnetip.readwrite.model
{

    public class CEMIAdditionalInformationBusmonitorInfo : CEMIAdditionalInformation
    {
        // Accessors for discriminator values.
        public override byte GetAdditionalInformationType() {
            return 0x03;
        }

        // Constant values.
        public const byte LEN = 1;

        // Properties.
        public bool FrameErrorFlag { get; }
        public bool BitErrorFlag { get; }
        public bool ParityErrorFlag { get; }
        public bool UnknownFlag { get; }
        public bool LostFlag { get; }
        public byte SequenceNumber { get; }

        public CEMIAdditionalInformationBusmonitorInfo(bool frameErrorFlag, bool bitErrorFlag, bool parityErrorFlag, bool unknownFlag, bool lostFlag, byte sequenceNumber)
        {
            FrameErrorFlag = frameErrorFlag;
            BitErrorFlag = bitErrorFlag;
            ParityErrorFlag = parityErrorFlag;
            UnknownFlag = unknownFlag;
            LostFlag = lostFlag;
            SequenceNumber = sequenceNumber;
        }

    }

}
