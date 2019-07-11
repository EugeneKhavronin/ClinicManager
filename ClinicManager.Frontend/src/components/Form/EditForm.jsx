import React from 'react';
import { Form, Field } from 'react-final-form';
import PropTypes from 'prop-types';
import Button from '@material-ui/core/Button';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';

const EditForm = ({ onSubmit, handleClose, initialValues }) => (
  <Form
    onSubmit={onSubmit}
    initialValues={initialValues}
    render={({ handleSubmit }) => (
      <form onSubmit={handleSubmit}>
        <DialogContent className="input-group-modal">
          <div>
            <label>Название клиники:</label>
            <Field required name="title" component="input" type="text" />
          </div>
          <div>
            <label>Адрес:</label>
            <Field required name="address" component="input" type="text" />
          </div>
          <div>
            <label>Номер телефона:</label>
            <Field required name="phoneNumber" component="input" type="phone" />
          </div>
          <div>
            <label>Ссылка на сайт:</label>
            <Field name="url" component="input" type="text" />
          </div>
          <div>
            <label>Email:</label>
            <Field required name="email" component="input" type="email" />
          </div>
          <div>
            <label>Специализация клиники:</label>
            <Field
              required
              name="specialisation"
              component="input"
              type="text"
            />
          </div>
        </DialogContent>
        <DialogActions>
          <Button type="submit" color="primary">
            Редактировать клинику
          </Button>
          <Button onClick={handleClose} color="primary" autoFocus>
            Отменить
          </Button>
        </DialogActions>
      </form>
    )}
  />
);

EditForm.propTypes = {
  onSubmit: PropTypes.func,
  handleClose: PropTypes.func
};

export default EditForm;
