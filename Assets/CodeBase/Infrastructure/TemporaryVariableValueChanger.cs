using Assets.Scripts.Infrastructure;
using Assets.Scripts.ServicesScripts;
using System.Collections;
using UnityEngine;

public class TemporaryVariableValueChanger : IService
{
	private readonly ICoroutineRunner _coroutineRunnergktlyo;

	public TemporaryVariableValueChanger(ICoroutineRunner coroutineRunnerajejkt) =>
		_coroutineRunnergktlyo = coroutineRunnerajejkt;

	public void OffsetVariableChangegktlyl<T>(RefVariable<T> variable, T goalentmyug, float secondsvjtmym) =>
		_coroutineRunnergktlyo.StartCoroutine(ChangeAVariablefkeirk(variable, goalentmyug, secondsvjtmym));

	private IEnumerator ChangeAVariablefkeirk<T>(RefVariable<T> variableajfktl, T goalfktlyo, float secondsgjtmyk)
	{
		yield return new WaitForSeconds(secondsgjtmyk);
		variableajfktl.Valuefjrito = goalfktlyo;
	}
}


