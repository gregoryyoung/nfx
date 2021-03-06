/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2014 IT Adapter Inc / 2015 Aum Code LLC
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
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFX.Collections;
using NFX.Media.TagCodes.QR;
using NUnit.Framework;

namespace NFX.NUnit.Media.TagCodes.QR
{
  [TestFixture]
  public class QRCodeTest
  {
    [Test]
    public void LinkH()
    {
      QREncoderMatrix matrix = QREncoderMatrix.Encode("www.dxwizard.com/KUKU-BASHA", QRCorrectionLevel.H);

      const string expected = 
@"Mode: BYTE
CorrectionLevel: H
Version: 4
Mask: 3
Matrix:
1 1 1 1 1 1 1 0 0 0 0 0 0 1 1 1 0 0 1 1 1 0 1 1 0 0 1 1 1 1 1 1 1
1 0 0 0 0 0 1 0 0 0 0 0 0 1 1 0 1 0 0 0 1 1 1 1 0 0 1 0 0 0 0 0 1
1 0 1 1 1 0 1 0 0 1 1 0 0 1 0 0 0 1 0 0 0 0 0 0 0 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 0 0 1 0 1 1 0 0 1 0 1 1 1 0 1 1 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 0 0 0 1 1 1 0 0 0 1 1 0 0 1 1 0 1 0 1 1 1 0 1
1 0 0 0 0 0 1 0 0 1 1 0 0 0 0 1 1 0 1 1 0 0 1 1 0 0 1 0 0 0 0 0 1
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 1 1 1 1 1 1
0 0 0 0 0 0 0 0 1 0 1 0 0 1 0 0 1 0 1 1 1 0 1 0 1 0 0 0 0 0 0 0 0
0 0 1 1 0 0 1 1 1 0 0 1 0 1 1 0 1 1 1 0 1 0 0 1 0 1 1 0 1 0 0 0 0
0 0 1 0 1 0 0 0 1 1 0 0 1 0 0 0 0 0 0 1 0 1 1 0 0 0 1 1 0 0 0 0 1
0 1 1 0 0 0 1 0 0 0 1 1 1 0 0 0 0 1 1 0 0 0 0 1 0 1 1 1 1 0 1 1 1
1 0 1 0 1 1 0 0 0 1 1 0 1 1 0 1 1 1 1 0 1 0 0 1 0 1 0 1 1 1 0 1 1
1 1 1 1 0 0 1 0 1 1 0 1 0 1 1 0 1 0 0 1 0 1 0 0 1 0 0 0 0 1 1 0 1
0 1 1 0 0 0 0 1 0 1 1 0 1 1 0 1 1 0 0 0 0 0 1 0 1 0 0 0 0 1 0 1 0
0 1 0 1 1 0 1 0 0 0 0 1 0 0 1 0 0 0 0 1 0 1 0 0 1 0 0 1 1 1 0 0 0
0 1 0 0 0 1 0 1 1 0 1 1 1 0 0 1 0 0 0 1 0 1 1 1 1 1 0 1 0 0 1 1 1
0 1 0 1 1 0 1 1 1 1 0 0 1 1 0 1 0 0 0 0 1 1 1 1 1 0 1 1 0 1 0 0 0
1 1 1 1 1 1 0 0 1 1 1 1 1 0 0 0 1 0 0 1 1 1 1 1 1 1 1 1 1 1 0 1 0
0 0 1 1 0 1 1 0 1 1 1 0 1 0 0 1 0 1 1 1 0 1 1 0 1 1 1 0 1 1 0 1 0
0 0 0 1 1 1 0 0 1 0 1 0 1 1 1 0 0 0 1 0 0 0 1 1 1 0 0 0 1 0 0 0 1
1 1 1 0 1 0 1 1 1 0 0 0 0 1 1 0 1 1 0 1 0 1 1 0 1 0 1 0 0 1 1 1 1
1 0 0 0 1 1 0 0 0 0 1 1 1 1 0 1 1 1 1 1 0 1 0 0 1 0 0 0 0 0 1 0 0
0 0 1 0 0 0 1 0 1 0 1 1 1 1 1 1 0 1 1 1 0 1 0 1 1 1 0 0 1 0 0 1 1
0 1 1 1 1 0 0 0 0 0 0 0 0 0 0 0 0 1 0 0 1 0 0 0 0 1 1 0 1 1 0 0 1
1 0 1 0 1 1 1 0 0 0 1 1 0 0 0 1 1 1 0 0 1 1 1 0 1 1 1 1 1 1 0 1 1
0 0 0 0 0 0 0 0 1 1 0 0 1 1 1 0 1 0 0 0 0 1 0 1 1 0 0 0 1 0 0 1 0
1 1 1 1 1 1 1 0 1 1 0 0 1 1 0 1 1 0 0 0 0 1 0 0 1 0 1 0 1 1 0 0 0
1 0 0 0 0 0 1 0 0 1 1 1 0 1 0 0 0 0 0 1 1 0 0 1 1 0 0 0 1 1 1 1 0
1 0 1 1 1 0 1 0 0 1 0 1 1 1 1 1 0 1 1 1 0 0 1 1 1 1 1 1 1 1 0 0 0
1 0 1 1 1 0 1 0 1 0 1 0 1 0 0 1 1 1 1 0 0 0 1 1 0 0 0 1 0 1 1 0 0
1 0 1 1 1 0 1 0 1 0 0 1 1 0 0 1 0 0 0 1 0 1 0 1 0 0 1 0 0 0 0 0 0
1 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 1 1 0 0 1 1 1 0 1 1 0 1 0 1
1 1 1 1 1 1 1 0 0 1 1 1 0 1 0 1 1 0 0 1 1 0 0 1 0 1 1 1 1 0 0 0 0";

      Assert.AreEqual(expected, matrix.ToString());
    }

    [Test]
    public void LinkQ()
    {
      QREncoderMatrix matrix = QREncoderMatrix.Encode("www.sl.com/MILA-ALEX", QRCorrectionLevel.Q);

      const string expected = 
@"Mode: BYTE
CorrectionLevel: Q
Version: 2
Mask: 4
Matrix:
1 1 1 1 1 1 1 0 0 1 0 0 0 0 1 0 1 0 1 1 1 1 1 1 1
1 0 0 0 0 0 1 0 0 0 0 1 0 1 0 0 1 0 1 0 0 0 0 0 1
1 0 1 1 1 0 1 0 1 0 1 0 1 0 0 1 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 0 0 1 1 0 0 1 1 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 1 0 0 1 1 0 1 0 1 0 1 1 1 0 1
1 0 0 0 0 0 1 0 1 1 0 0 0 1 0 0 1 0 1 0 0 0 0 0 1
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 0 1 0 1 1 1 1 1 1 1
0 0 0 0 0 0 0 0 0 1 0 1 0 0 1 1 0 0 0 0 0 0 0 0 0
0 1 0 0 1 0 1 0 1 1 1 1 0 1 0 1 0 1 0 1 1 0 1 0 0
0 1 1 1 1 0 0 1 1 1 0 0 0 0 0 1 0 0 0 0 1 1 0 1 0
1 1 1 0 0 1 1 1 0 1 0 0 0 0 0 1 0 0 1 1 1 0 0 0 0
0 1 0 1 1 1 0 0 0 1 1 1 1 0 0 1 1 0 0 1 1 1 1 0 1
0 1 0 0 1 0 1 0 1 1 0 1 1 1 1 0 0 0 1 1 0 0 1 1 1
1 0 1 1 0 0 0 1 0 1 0 1 1 1 1 0 1 0 0 0 1 1 1 1 0
0 0 1 0 1 0 1 0 0 1 0 1 0 1 1 1 1 0 1 1 1 1 0 0 0
0 0 0 0 1 1 0 1 0 1 0 0 0 1 1 1 0 0 1 0 0 0 1 0 1
1 1 0 1 0 0 1 0 0 0 1 0 1 1 1 1 1 1 1 1 1 1 1 1 1
0 0 0 0 0 0 0 0 1 0 1 0 0 0 0 0 1 0 0 0 1 0 0 1 0
1 1 1 1 1 1 1 0 0 1 1 1 1 1 0 1 1 0 1 0 1 0 0 0 0
1 0 0 0 0 0 1 0 0 1 1 0 1 0 0 0 1 0 0 0 1 0 1 1 0
1 0 1 1 1 0 1 0 1 1 0 0 1 1 0 0 1 1 1 1 1 0 1 1 1
1 0 1 1 1 0 1 0 0 0 0 1 1 1 0 1 0 1 1 1 0 1 1 1 1
1 0 1 1 1 0 1 0 0 1 0 0 0 0 1 1 0 1 0 1 0 1 1 1 0
1 0 0 0 0 0 1 0 1 0 0 1 1 1 0 1 1 0 1 0 1 1 1 1 0
1 1 1 1 1 1 1 0 0 0 0 1 1 1 1 1 0 1 1 0 0 0 1 1 1";

      Assert.AreEqual(expected, matrix.ToString());
    }

    [Test]
    public void LinkM()
    {
      QREncoderMatrix matrix = QREncoderMatrix.Encode("www.itadapter.com/GE-NI-AL-NO", QRCorrectionLevel.M);

      const string expected = 
@"Mode: BYTE
CorrectionLevel: M
Version: 3
Mask: 6
Matrix:
1 1 1 1 1 1 1 0 1 1 0 1 1 1 1 1 0 0 1 1 0 0 1 1 1 1 1 1 1
1 0 0 0 0 0 1 0 1 0 0 1 1 1 1 1 0 0 1 1 1 0 1 0 0 0 0 0 1
1 0 1 1 1 0 1 0 1 1 1 1 0 1 1 0 0 0 0 0 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 0 0 1 0 0 0 1 1 0 1 1 1 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 0 0 1 1 0 1 0 0 1 0 0 0 1 0 1 1 1 0 1
1 0 0 0 0 0 1 0 0 0 1 0 0 1 1 0 0 1 0 0 1 0 1 0 0 0 0 0 1
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 1 1 1 1 1 1
0 0 0 0 0 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 0 0 0 0 0
1 0 0 1 1 1 1 1 1 1 0 0 1 1 1 1 1 0 0 0 0 1 0 0 1 0 1 1 1
1 1 0 0 1 1 0 0 0 0 1 1 0 0 1 0 0 0 1 1 1 1 0 1 1 1 0 0 0
0 0 0 0 1 0 1 0 1 0 1 1 0 0 1 0 0 1 1 0 0 1 0 0 1 0 0 1 0
1 1 0 1 0 0 0 0 1 0 1 0 1 0 1 1 0 1 0 0 1 0 0 0 1 1 0 1 0
0 0 0 1 1 0 1 0 1 1 0 0 1 1 1 0 0 1 0 1 1 1 1 1 0 1 0 0 1
0 1 0 0 0 0 0 0 0 1 0 1 0 0 0 0 0 1 1 1 0 0 1 1 1 1 0 1 1
0 0 1 1 1 0 1 1 1 0 1 1 0 0 1 1 0 0 0 1 1 0 0 0 1 0 0 0 1
0 1 0 1 0 1 0 0 1 0 1 0 0 1 1 0 1 0 1 1 0 0 0 1 1 1 1 1 0
1 0 1 0 1 0 1 1 0 1 0 0 0 0 0 1 0 0 1 0 1 0 0 0 0 1 0 0 0
1 1 0 1 1 1 0 1 1 1 1 1 0 0 0 0 0 0 1 0 1 0 0 0 1 1 0 1 0
1 1 1 0 0 0 1 1 0 0 0 0 1 1 1 0 1 1 0 1 0 1 1 1 1 1 1 0 1
1 1 1 1 1 0 0 1 1 0 0 0 1 1 0 1 1 0 0 0 0 1 1 0 1 0 1 1 1
1 1 0 0 1 0 1 0 0 0 0 0 1 1 0 0 0 0 0 0 1 1 1 1 1 1 1 0 1
0 0 0 0 0 0 0 0 1 1 1 1 1 1 0 0 1 1 1 0 1 0 0 0 1 0 1 1 0
1 1 1 1 1 1 1 0 1 0 1 0 1 1 0 1 1 0 0 1 1 0 1 0 1 1 1 0 0
1 0 0 0 0 0 1 0 1 1 0 0 0 1 0 0 1 1 1 0 1 0 0 0 1 1 0 1 1
1 0 1 1 1 0 1 0 1 0 1 1 0 1 0 1 1 1 0 1 1 1 1 1 1 1 0 0 0
1 0 1 1 1 0 1 0 1 0 0 0 1 0 1 0 1 1 1 0 1 1 0 1 0 0 1 1 0
1 0 1 1 1 0 1 0 0 0 0 0 0 0 1 0 1 1 0 0 1 1 0 1 1 1 0 1 1
1 0 0 0 0 0 1 0 0 1 1 0 1 1 0 1 0 0 0 0 0 1 0 1 1 1 1 0 1
1 1 1 1 1 1 1 0 1 1 0 0 1 1 0 0 0 1 1 1 1 0 1 1 1 0 0 0 0";

      Assert.AreEqual(expected, matrix.ToString());
    }

    [Test]
    public void LinkL()
    {
      QREncoderMatrix matrix = QREncoderMatrix.Encode("https://www.nfx.com/articleId=100&b=m", QRCorrectionLevel.L);

      const string expected = 
@"Mode: BYTE
CorrectionLevel: L
Version: 3
Mask: 3
Matrix:
1 1 1 1 1 1 1 0 1 1 0 0 0 1 0 0 1 0 0 1 1 0 1 1 1 1 1 1 1
1 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 1 1 1 0 1 0 1 0 0 0 0 0 1
1 0 1 1 1 0 1 0 1 0 0 1 1 1 1 0 0 0 0 0 0 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 0 1 0 0 0 0 1 1 0 0 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 1 1 0 1 1 1 0 0 0 1 0 0 1 0 1 1 1 0 1
1 0 0 0 0 0 1 0 0 1 0 0 1 0 1 0 1 0 0 1 1 0 1 0 0 0 0 0 1
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 1 1 1 1 1 1
0 0 0 0 0 0 0 0 0 1 0 1 0 1 1 1 0 1 1 0 1 0 0 0 0 0 0 0 0
1 1 1 1 0 0 1 0 1 0 0 0 0 1 1 0 1 1 1 1 0 1 0 0 1 1 1 0 1
0 1 0 1 0 0 0 1 1 1 0 0 0 0 0 0 1 0 1 1 1 1 1 1 1 0 0 0 1
0 0 0 1 1 1 1 0 0 0 0 0 0 0 1 0 0 0 0 0 0 1 1 1 1 0 1 1 0
0 1 0 1 1 0 0 1 1 0 0 1 1 1 1 1 0 0 1 0 1 0 0 1 1 0 0 0 1
0 0 0 0 0 1 1 0 1 1 0 1 0 0 0 1 0 1 0 1 0 0 0 0 0 1 1 0 0
1 1 0 0 0 0 0 0 1 0 1 1 0 1 0 1 0 0 0 1 1 0 1 1 0 0 1 1 1
0 0 0 0 1 1 1 0 0 0 0 0 1 0 1 0 1 0 1 1 1 1 1 1 1 0 1 1 1
0 1 0 0 0 1 0 1 0 1 0 0 1 1 0 1 0 0 1 0 1 1 1 1 1 0 0 1 0
1 0 1 0 1 1 1 0 1 1 0 1 0 0 0 0 1 0 1 1 1 1 0 0 1 1 0 1 0
0 1 0 0 0 1 0 0 0 0 1 0 1 1 0 1 1 0 0 0 1 1 0 1 0 1 1 1 0
1 0 0 0 1 0 1 1 0 1 0 1 1 0 0 1 0 0 0 0 1 1 1 1 0 0 1 0 0
0 0 1 1 1 0 0 1 0 0 1 0 1 0 0 0 0 1 1 1 0 0 0 0 0 0 1 0 0
0 1 0 0 0 1 1 1 0 1 0 1 1 1 0 0 0 0 1 0 1 1 1 1 1 1 1 0 0
0 0 0 0 0 0 0 0 1 0 1 0 1 1 1 0 0 1 1 0 1 0 0 0 1 1 1 1 1
1 1 1 1 1 1 1 0 0 0 1 1 1 1 0 0 1 1 0 1 1 0 1 0 1 1 0 1 0
1 0 0 0 0 0 1 0 0 1 1 0 0 0 0 0 1 0 1 0 1 0 0 0 1 1 0 1 1
1 0 1 1 1 0 1 0 0 1 0 0 1 0 1 1 1 1 0 0 1 1 1 1 1 0 1 0 0
1 0 1 1 1 0 1 0 1 1 1 1 1 0 1 1 0 1 0 1 0 0 0 0 1 1 0 0 1
1 0 1 1 1 0 1 0 1 0 0 1 0 1 0 0 0 0 1 1 0 0 0 1 0 0 1 0 1
1 0 0 0 0 0 1 0 1 1 1 1 0 0 1 1 1 0 1 0 1 0 1 1 0 1 0 1 0
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 0 1 0 0 1 0 1 0";

      Assert.AreEqual(expected, matrix.ToString());
    }

    [Test]
    public void ParallelGeneration()
    {
      const int TOTAL = 1000;

      const string expected = 
@"Mode: BYTE
CorrectionLevel: L
Version: 3
Mask: 3
Matrix:
1 1 1 1 1 1 1 0 1 1 0 0 0 1 0 0 1 0 0 1 1 0 1 1 1 1 1 1 1
1 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 1 1 1 0 1 0 1 0 0 0 0 0 1
1 0 1 1 1 0 1 0 1 0 0 1 1 1 1 0 0 0 0 0 0 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 0 1 0 0 0 0 1 1 0 0 1 0 1 0 1 1 1 0 1
1 0 1 1 1 0 1 0 1 1 1 1 0 1 1 1 0 0 0 1 0 0 1 0 1 1 1 0 1
1 0 0 0 0 0 1 0 0 1 0 0 1 0 1 0 1 0 0 1 1 0 1 0 0 0 0 0 1
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 1 1 1 1 1 1
0 0 0 0 0 0 0 0 0 1 0 1 0 1 1 1 0 1 1 0 1 0 0 0 0 0 0 0 0
1 1 1 1 0 0 1 0 1 0 0 0 0 1 1 0 1 1 1 1 0 1 0 0 1 1 1 0 1
0 1 0 1 0 0 0 1 1 1 0 0 0 0 0 0 1 0 1 1 1 1 1 1 1 0 0 0 1
0 0 0 1 1 1 1 0 0 0 0 0 0 0 1 0 0 0 0 0 0 1 1 1 1 0 1 1 0
0 1 0 1 1 0 0 1 1 0 0 1 1 1 1 1 0 0 1 0 1 0 0 1 1 0 0 0 1
0 0 0 0 0 1 1 0 1 1 0 1 0 0 0 1 0 1 0 1 0 0 0 0 0 1 1 0 0
1 1 0 0 0 0 0 0 1 0 1 1 0 1 0 1 0 0 0 1 1 0 1 1 0 0 1 1 1
0 0 0 0 1 1 1 0 0 0 0 0 1 0 1 0 1 0 1 1 1 1 1 1 1 0 1 1 1
0 1 0 0 0 1 0 1 0 1 0 0 1 1 0 1 0 0 1 0 1 1 1 1 1 0 0 1 0
1 0 1 0 1 1 1 0 1 1 0 1 0 0 0 0 1 0 1 1 1 1 0 0 1 1 0 1 0
0 1 0 0 0 1 0 0 0 0 1 0 1 1 0 1 1 0 0 0 1 1 0 1 0 1 1 1 0
1 0 0 0 1 0 1 1 0 1 0 1 1 0 0 1 0 0 0 0 1 1 1 1 0 0 1 0 0
0 0 1 1 1 0 0 1 0 0 1 0 1 0 0 0 0 1 1 1 0 0 0 0 0 0 1 0 0
0 1 0 0 0 1 1 1 0 1 0 1 1 1 0 0 0 0 1 0 1 1 1 1 1 1 1 0 0
0 0 0 0 0 0 0 0 1 0 1 0 1 1 1 0 0 1 1 0 1 0 0 0 1 1 1 1 1
1 1 1 1 1 1 1 0 0 0 1 1 1 1 0 0 1 1 0 1 1 0 1 0 1 1 0 1 0
1 0 0 0 0 0 1 0 0 1 1 0 0 0 0 0 1 0 1 0 1 0 0 0 1 1 0 1 1
1 0 1 1 1 0 1 0 0 1 0 0 1 0 1 1 1 1 0 0 1 1 1 1 1 0 1 0 0
1 0 1 1 1 0 1 0 1 1 1 1 1 0 1 1 0 1 0 1 0 0 0 0 1 1 0 0 1
1 0 1 1 1 0 1 0 1 0 0 1 0 1 0 0 0 0 1 1 0 0 0 1 0 0 1 0 1
1 0 0 0 0 0 1 0 1 1 1 1 0 0 1 1 1 0 1 0 1 0 1 1 0 1 0 1 0
1 1 1 1 1 1 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 0 1 0 0 1 0 1 0";

      System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

      System.Threading.Tasks.Parallel.For(0, TOTAL, (i) => {
          QREncoderMatrix matrix = QREncoderMatrix.Encode("https://www.nfx.com/articleId=100&b=m", QRCorrectionLevel.L);
          Assert.AreEqual(expected, matrix.ToString());
      });

      long time = watch.ElapsedMilliseconds;
      Console.WriteLine("Long QR generation test took {0}ms for {1} objects @ {2}op/sec".Args(time, TOTAL, TOTAL / (time / 1000d)));
    }
  }
}
