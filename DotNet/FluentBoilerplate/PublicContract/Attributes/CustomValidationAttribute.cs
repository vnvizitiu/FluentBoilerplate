﻿/*
   Copyright 2015 Chris Hannon

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBoilerplate.Runtime.Extensions;

namespace FluentBoilerplate
{
    /// <summary>
    /// Indicates that the property has some custom validation attached to it.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=true)]
    public sealed class CustomValidationAttribute:Attribute, IValidationAttribute
    {
        /// <summary>
        /// Gets the type of the validator.
        /// </summary>
        /// <value>
        /// The type of the validator.
        /// </value>
        public Type ValidatorType { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomValidationAttribute"/> class.
        /// </summary>
        /// <param name="validatorType">Type of the validator. This must be assignable to <see cref="ICustomValidator"/> of the property type.</param>
        public CustomValidationAttribute(Type validatorType)
        {
            this.ValidatorType = validatorType;
        }
    }
}
