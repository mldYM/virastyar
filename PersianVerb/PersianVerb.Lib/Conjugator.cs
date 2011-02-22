﻿// Virastyar
// http://www.virastyar.ir
// Copyright (C) 2011 Supreme Council for Information and Communication Technology (SCICT) of Iran
// 
// This file is part of Virastyar.
// 
// Virastyar is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Virastyar is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Virastyar.  If not, see <http://www.gnu.org/licenses/>.
// 
// Additional permission under GNU GPL version 3 section 7
// The sole exception to the license's terms and requierments might be the
// integration of Virastyar with Microsoft Word (any version) as an add-in.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCICT.Utility;

namespace SCICT.NLP.Morphology.Inflection.Conjugation
{
    public class Conjugator
    {
        private VerbInfoContainer m_verbInfoContainer;
        private VerbWrapper m_verbWrapper;

        public Conjugator(VerbInfoContainer dic)
        {
            m_verbInfoContainer = dic;
            m_verbInfoContainer.ResetIndex();
        }

        private ENUM_TENSE_TIME[] m_timeList = 
        {
            ENUM_TENSE_TIME.MAZI_E_SADE, 
            ENUM_TENSE_TIME.MAZI_E_ESTEMRARI,
            ENUM_TENSE_TIME.MAZI_E_SADEYE_NAGHLI,
            ENUM_TENSE_TIME.MAZI_E_ESTEMRARIE_NAGHLI,
            ENUM_TENSE_TIME.MOZARE_E_EKHBARI,
            ENUM_TENSE_TIME.MOZARE_E_ELTEZAMI,
            ENUM_TENSE_TIME.AMR
        };

        public string[] Conjugate(ENUM_VERB_TYPE verbType)
        {
            VerbEntry ve;
            m_verbWrapper = new VerbWrapper();

            List<string> lst = new List<string>();
            m_verbInfoContainer.ResetIndex();
            while ((ve = m_verbInfoContainer.GetVerbEntry()) != null)
            {
                m_verbWrapper.SetVerbEntry(ve);
                m_verbWrapper.setTensePassivity(ENUM_TENSE_PASSIVITY.ACTIVE);

                if (verbType.Has(ENUM_VERB_TYPE.INFINITIVE))
                {
                    lst.AddRange(m_verbWrapper.PrintInfinitive());
                }

                if(!verbType.Has(ve.verbType))
                    continue;

                #region Conjugate

                foreach (ENUM_TENSE_TIME tm in m_timeList)
                {
                    m_verbWrapper.setTenseTime(tm);
                    //foreach (ENUM_TENSE_OBJECT obj in Enum.GetValues(typeof(ENUM_TENSE_OBJECT)))
                    foreach (ENUM_TENSE_POSITIVITY pos in Enum.GetValues(typeof(ENUM_TENSE_POSITIVITY)))
                    {
                        m_verbWrapper.setTensePositivity(pos);
                        if (!m_verbWrapper.IsValidPositivity())
                            continue;

                        foreach (ENUM_TENSE_PERSON person in Enum.GetValues(typeof(ENUM_TENSE_PERSON)))
                        {
                            if (person == ENUM_TENSE_PERSON.INVALID || person == ENUM_TENSE_PERSON.UNMACHED_SEGMENT)
                                continue;

                            m_verbWrapper.setTensePerson(person);

                            if (m_verbWrapper.isValidTense(ENUM_VERB_TRANSITIVITY.INTRANSITIVE))
                                lst.Add(m_verbWrapper.PrintVerb().Split(' ')[0]);
                        }
                    }
                }

                #endregion
            }

            return lst.Distinct().ToArray();
        }

    }
}
