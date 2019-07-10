import React from 'react';
import DialogTitle from '@material-ui/core/DialogTitle';

import Modal from '../components/Modal';
import AddForm from '../components/Form';

class Header extends React.Component {
  state = {
    isOpen: false
  };

  sleep = ms => new Promise(resolve => setTimeout(resolve, ms));

  onSubmit = async values => {
    await this.sleep(300);
    console.log(values)
  };

  handleClickOpen = () => {
    this.setState({ isOpen: true });
  };

  handleClose = () => {
    this.setState({ isOpen: false });
  };

  render() {
    const { isOpen } = this.state;

    return (
      <header className="header-back">
        <h1>Clinic Manager</h1>
        <button
          type="button"
          className="button-add"
          onClick={this.handleClickOpen}
        >
          Добавить клинику
        </button>
        <Modal isOpen={isOpen} handleClose={this.handleClose}>
          <DialogTitle id="alert-dialog-title">Добавить клинику</DialogTitle>
          <AddForm onSubmit={this.onSubmit} handleClose={this.handleClose} />
        </Modal>
      </header>
    );
  }
}

export default Header;
