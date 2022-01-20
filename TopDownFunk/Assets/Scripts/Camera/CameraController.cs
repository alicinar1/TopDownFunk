using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.CameraController
{
	public class CameraController : MonoBehaviour
	{
		[SerializeField] private Transform _target;
		[SerializeField] private Vector3 _targetOffset;
		[SerializeField] private float _moveSpeed = 2f;

		private Transform _myTransform;

		private void Start()
		{
			// Cache camera transform
			_myTransform = transform;
		}

		public void SetTarget(Transform aTransform)
		{
			_target = aTransform;
		}

		private void LateUpdate()
		{
			if (_target != null)
				_myTransform.position = Vector3.Lerp(_myTransform.position, _target.position + _targetOffset, _moveSpeed * Time.deltaTime);
		}
	}
}
