import React from 'react';
import DialogTitle from '@material-ui/core/DialogTitle';

import Modal from '../components/Modal';
import { CreateForm } from '../components/Form';

class Header extends React.Component {
  render() {
    const { submitCreateClinic, handleClickOpen, handleClose, isOpen } = this.props;

    return (
      <header className="header-back">
        <h1>Clinic Manager</h1>
        <button type="button" className="button-add" onClick={handleClickOpen}>
          Добавить клинику
        </button>
        <Modal isOpen={isOpen} handleClose={handleClose}>
          <DialogTitle id="alert-dialog-title">Добавить клинику</DialogTitle>
          <CreateForm onSubmit={submitCreateClinic} handleClose={handleClose} />
        </Modal>
      </header>
    );
  }
}

export default Header;
