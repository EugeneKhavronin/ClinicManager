import React from 'react';
import DialogTitle from '@material-ui/core/DialogTitle';
import Avatar from '@material-ui/core/Avatar';
import { makeStyles } from '@material-ui/core/styles';

import Modal from '../components/Modal';
import { CreateForm } from '../components/Form';
import PersonIcon from '@material-ui/icons/Person';

const useStyles = makeStyles(() => ({
  bigAvatar: {
    position: 'absolute',
    top: 5,
    right: 160,
    width: 60,
    height: 60
  }
}));
const Header = ({
  submitCreateClinic,
  handleClickOpen,
  handleClose,
  isOpen
}) => {
  const classes = useStyles();

  return (
    <header className="header-back">
      <h1>Личный медицинский кабинет</h1>
      <h5>Сорокин Е. А.</h5>
      <div className={classes.root}>
        <Avatar
          alt="Remy Sharp"
          src="http://vnuki.by/images/RTvr231qD9j3hN5LJ0khvBbXUNZqTOvhnuQ53YOK5yVWpTazi6.jpg"
          className={classes.bigAvatar}
        />
      </div>
      <button type="button" className="button-add">
        Выйти
      </button>

      <Modal isOpen={isOpen} handleClose={handleClose}>
        <DialogTitle id="alert-dialog-title">Добавить клинику</DialogTitle>
        <CreateForm onSubmit={submitCreateClinic} handleClose={handleClose} />
      </Modal>
    </header>
  );
};

export default Header;
