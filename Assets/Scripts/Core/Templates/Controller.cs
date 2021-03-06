﻿/*
 * Author(s): Isaiah Mann
 * Description: Meta class that all controllers inherit from (all controllers are singletons)
 */

public abstract class Controller : MonoBehaviourExtended {
	protected InputController input;

	protected override void SetReferences () {
		// Nothing
	}

	protected override void FetchReferences () {
		input = InputController.Instance;
	}

	protected override void HandleNamedEvent (string eventName) {
		// Nothing
	}

	protected override void CleanupReferences () {
		// Nothing
	}
}
