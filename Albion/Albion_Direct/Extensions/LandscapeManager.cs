﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Albion_Direct
{
    public partial class LandscapeManager
    {
        public List<ag4> GetUnrestrictedPvpZones => _internal.g().e;

        public bool IsInAnyUnrestrictedPvpZone(Vector3 location) => IsInAnyUnrestrictedPvpZone(GetUnrestrictedPvpZones, location);

        public bool IsInAnyUnrestrictedPvpZone(IEnumerable<ag4> pvpZones, Vector3 location) => pvpZones.Any(pvpZone => Mathf.Pow(location.x - pvpZone.k(), 2) + Mathf.Pow(location.z - pvpZone.l(), 2) < Mathf.Pow(pvpZone.m(), 2));

        public bool IsInAnyUnrestrictedPvpZone(Func<ag4, bool> selector, Vector3 location) => IsInAnyUnrestrictedPvpZone(GetUnrestrictedPvpZones.Where(selector), location);
    }
}