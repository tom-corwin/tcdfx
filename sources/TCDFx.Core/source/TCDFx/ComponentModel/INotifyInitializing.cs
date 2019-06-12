/***************************************************************************************************
 * FileName:             INotifyInitializing.cs
 * Copyright:            Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

using System;

namespace TCDFx.ComponentModel
{
    /// <summary>
    /// Notifies clients that a component has started to initialize.
    /// </summary>
    public interface INotifyInitializing
    {
        /// <summary>
        /// Occurs when a component has started to initialize.
        /// </summary>
        event EventHandler<Component, EventArgs> Initializing;
    }
}