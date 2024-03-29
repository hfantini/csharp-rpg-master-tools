﻿/*

    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +
    |
    |	RPGMasterTools
    |
    |	A multitool software for D&D game masters.
    |	
    |	== INFO ==
    |
    |	By Henrique Fantini @ 2019
    |	www.henriquefantini.com
    |	contact@henriquefantini.com
    |
    |	== FILE DETAILS 
    |
    |	Name: [EMasterToolsException.cs]
    |	Type: [EXCEPTION]
    |	Author: Henrique Fantini
    |	
    |	Description: Defines a generic system exception.
    |
    + - - - - - - - - - - - - - - - - - - - - - - - - - - - - - +

*/


// == IMPORTS
// ==================================================================

using RPGMasterTools.Source.Enumeration.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// == NAMESPACE
// ==================================================================


namespace RPGMasterTools.Source.Model.Exception
{
    // == CLASS
    // ==============================================================

    public class EMasterToolsException : System.Exception
    {
        // == DECLARATIONS
        // ==============================================================

        // -- CONST -----------------------------------------------------
        private const String GENERIC_EXCEPTION_MESSAGE = "Unknown error!";

        // -- VAR -------------------------------------------------------

        private ExceptionType _type;

        // == CONSTRUCTOR(S)
        // ==============================================================

        public EMasterToolsException() : base(GENERIC_EXCEPTION_MESSAGE)
        {
            this._type = ExceptionType.TYPE_FATAL;
        }

        public EMasterToolsException(System.Exception e) : base(e.Message, e)
        {
            this._type = ExceptionType.TYPE_FATAL;
        }

        public EMasterToolsException(System.Exception e, ExceptionType type) : base(e.Message, e)
        {
            this._type = type;
        }

        public EMasterToolsException(System.Exception e, ExceptionType type, String message) : base(message, e)
        {
            this._type = type;
        }

        // == METHODS
        // ==============================================================

        // == GETTER(S) AND SETTER(S)
        // ==============================================================

        public ExceptionType type
        {
            get { return this._type; }
        }
    }
}
