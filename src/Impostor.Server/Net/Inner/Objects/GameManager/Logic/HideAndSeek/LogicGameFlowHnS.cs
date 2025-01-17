﻿using Impostor.Api.Net.Inner.Objects.GameManager.Logic.HideAndSeek;

namespace Impostor.Server.Net.Inner.Objects.GameManager.Logic.HideAndSeek;

internal class LogicGameFlowHnS : LogicGameFlow, ILogicGameFlowHnS
{
    public float CurrentFinalHideTime { get; private set; }

    public float CurrentHideTime { get; private set; }

    public override void Deserialize(IMessageReader reader, bool initialState)
    {
        var num = reader.ReadSingle();

        CurrentFinalHideTime = reader.ReadSingle();
        CurrentHideTime = num;
    }
}
