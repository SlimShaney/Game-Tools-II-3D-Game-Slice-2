using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {
    [SerializeField] GameObject spellEffect;
    [SerializeField] Transform effectReference;
    [SerializeField] Character player;

    private void OnEnable()
    {
        player.OnFire.AddListener(Fire);
    }

    private void OnDisable()
    {
        player.OnFire.RemoveListener(Fire);
    }

    public void Fire()
    {
        Instantiate(spellEffect, effectReference.position, effectReference.rotation);
    }
}
