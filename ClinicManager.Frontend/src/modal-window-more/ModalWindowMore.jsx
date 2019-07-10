import React from 'react';
import './modal-window-more.css';

const ModalWindowMore = () => {
  return (
    <div className="modal fade">
      <div className="modal-dialog" role="document">
        <div className="modal-content">
          <div className="modal-header">
            <button
              type="button"
              className="close"
              data-dismiss="modal"
              aria-label="Close"
            >
              <span aria-hidden="true">&times;</span>
            </button>
            <h4 className="modal-title">Modal title</h4>
          </div>
          <div className="modal-body">
            <p>One fine body&hellip;</p>
          </div>
          <div className="modal-footer">
            <button
              type="button"
              className="btn btn-secondary"
              data-dismiss="modal">
              Close
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};
export default ModalWindowMore;
