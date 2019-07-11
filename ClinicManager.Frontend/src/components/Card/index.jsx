import React, { Fragment } from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import CardMedia from '@material-ui/core/CardMedia';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';
import Fab from '@material-ui/core/Fab';
import DeleteIcon from '@material-ui/icons/Delete';
import EditIcon from '@material-ui/icons/Edit';

import { getFile } from '../../utils';

const useStyles = makeStyles({
  card: {
    width: 345,
    margin: 5
  },
  media: {
    height: 140
  },
  cardAction: {
    justifyContent: 'space-between'
  },
  fab: {
    width: 35,
    height: 35,
    margin: 5
  }
});

export default function MediaCard({
  title,
  address,
  phoneNumber,
  url,
  email,
  specialisation,
  handleClickEditOpen,
  onDeleted,
  handleClickOpenMore,
  pictureGuid
}) {
  const classes = useStyles();

  return (
    <Card className={classes.card}>
      <Fragment>
        <CardMedia
          className={classes.media}
          image={getFile(pictureGuid)}
          title="Contemplative Reptile"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="h2">
            {title}
          </Typography>
          <Typography variant="body2" color="textSecondary" component="p">
            Email:
            <a href={`mailto:${email}`}>{email}</a>
          </Typography>
          <Typography variant="body2" color="textSecondary" component="p">
            Телефон:
            {phoneNumber}
          </Typography>
          <Typography variant="body2" color="textSecondary" component="p">
            Адрес:
            {address}
          </Typography>
        </CardContent>
      </Fragment>
      <CardActions className={classes.cardAction}>
        <Button size="small" color="primary" onClick={handleClickOpenMore}>
          Подробнее
        </Button>
        <div>
          <Fab aria-label="Edit" className={classes.fab} onClick={handleClickEditOpen}>
            <EditIcon />
          </Fab>
          <Fab aria-label="Delete" className={classes.fab} onClick={onDeleted}>
            <DeleteIcon />
          </Fab>
        </div>
      </CardActions>
    </Card>
  );
}
