NDSummary.OnToolTipsLoaded("File3:Input/VRSimulatorInputHandler.cs",{9:"<div class=\"NDToolTip TClass LCSharp\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype9\"><div class=\"CPEntry TClass Current\"><div class=\"CPPrePrototypeLine\"><span class=\"SHMetadata\">[CustomEditor(typeof(VRSimulatorInputHandler))]</span></div><div class=\"CPModifiers\"><span class=\"SHKeyword\">public</span></div><div class=\"CPName\">VRSimulatorInputHandlerEditor</div></div></div></div>",11:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype11\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">override public void</span> OnInspectorGUI()</div></div>",12:"<div class=\"NDToolTip TClass LCSharp\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype12\"><div class=\"CPEntry TClass Current\"><div class=\"CPPrePrototypeLine\"><span class=\"SHMetadata\">[RequireComponent(typeof(VRSimulator))]</span></div><div class=\"CPModifiers\"><span class=\"SHKeyword\">public</span></div><div class=\"CPName\">VRSimulatorInputHandler</div></div></div><div class=\"TTSummary\">Component for handling user inputs to control the required VRSimulator component.</div></div>",14:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype14\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">bool</span> invertYAxis</div><div class=\"TTSummary\">Decides if the y-axis to control the simulator hmd should be inverted.</div></div>",15:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype15\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> controllersActive</div></div>",16:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype16\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> switchAxis</div></div>",17:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype17\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> toggleRotation</div></div>",18:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype18\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> switchController</div></div>",19:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype19\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> controllerMoving</div></div>",20:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype20\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> looking</div></div>",21:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype21\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> moving</div></div>",22:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype22\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> stickActive</div></div>",23:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype23\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private float</span> controllerMovementSpeed</div><div class=\"TTSummary\">Speed for controller movement.</div></div>",24:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype24\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private float</span> controllerRotationSpeed</div><div class=\"TTSummary\">Speed for controller rotation.</div></div>",25:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype25\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private float</span> movementSpeed</div><div class=\"TTSummary\">Speed for HMD movement.</div></div>",26:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype26\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private float</span> lookSpeed</div><div class=\"TTSummary\">Speed for HMD rotation.</div></div>",27:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype27\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div><span class=\"SHKeyword\">private bool</span> lockCursor</div><div class=\"TTSummary\">Bool for deciding if the mouse can be locked/hidden while controlling the simulator.</div></div>",28:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype28\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private bool</span> m_cursorIsLocked</div></div>",29:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype29\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div>InputActionAsset inputActions</div><div class=\"TTSummary\">InputActionAsset that holds the control bindings for all simulator actions. Only visible if using Unity Input System.</div></div>",30:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype30\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private float</span> legacyMouseCompensation</div></div>",31:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype31\" class=\"NDPrototype NoParameterForm\"><div class=\"PPrePrototypeLine\"><span class=\"SHMetadata\">[SerializeField]</span></div>InputAssign assignedKeys</div><div class=\"TTSummary\">&lt;InputAssign&gt; holding control bindings for all simulator actions. Only visible if using Legacy Input Manager.</div></div>",32:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype32\" class=\"NDPrototype NoParameterForm\">VRSimulator simulator</div></div>",33:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype33\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private bool</span> showOverlay</div></div>",34:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype34\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private</span> Text overlayText</div></div>",35:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype35\" class=\"NDPrototype NoParameterForm\">Vector2 moveDirection</div></div>",36:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype36\" class=\"NDPrototype NoParameterForm\">Vector2 lookDelta</div></div>",37:"<div class=\"NDToolTip TVariable LCSharp\"><div id=\"NDPrototype37\" class=\"NDPrototype NoParameterForm\">Vector3 controllerDelta</div></div>",39:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype39\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private void</span> Start()</div></div>",40:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype40\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private void</span> Update()</div></div>",41:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype41\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> InitInputSystem()</div><div class=\"TTSummary\">Initializes the required input actions found in inputActions and sets event callbacks.</div></div>",42:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype42\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> LookUpdate()</div><div class=\"TTSummary\">Update function for handling hmd rotation input.</div></div>",43:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype43\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> MoveUpdate()</div><div class=\"TTSummary\">Update function for handling hmd movement input.</div></div>",44:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype44\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> ControllerUpdate()</div><div class=\"TTSummary\">Update function for handling controller movement and rotation input. Rotates the active controller if toggleRotation is true or moves it otherwise.</div></div>",45:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype45\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> UpdateControllerHandling()</div><div class=\"TTSummary\">Update function for handling controller input states (Reset/Toggle Controllers/Rotation/Switch Hands). Only needed for Legacy Input.</div></div>",46:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype46\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> UpdateInteraction()</div><div class=\"TTSummary\">Update function for handling controller interaction input (buttons etc.).</div></div>",47:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype47\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">void</span> ShowKeyOverlay(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName last\">show</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Function for showing or hiding overlay ui with simulator controls.</div></div>",48:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype48\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">public void</span> SetCursorLock(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName last\">value</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Sets the cursor lock state if lockCursor is true.</div></div>",49:"<div class=\"NDToolTip TFunction LCSharp\"><div id=\"NDPrototype49\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">private void</span> UpdateCursorLock()</div><div class=\"TTSummary\">Updates the cursor lock state if lockCursor is true.</div></div>"});